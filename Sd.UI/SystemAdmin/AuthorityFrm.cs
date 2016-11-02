using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Sd.BLL;
using Sd.IBLL;
using Sd.Model;

namespace Sd.UI.SystemAdmin
{
    public partial class AuthorityFrm : Form
    {
        #region 变量声明或者定义
        private readonly List<CompetenceSet> _competenceList;
        private List<CompetenceSet> _childNodes;
        private password _curUser;
        private List<int> _curUserCompetence;
        #endregion

        #region 各种事件
        public AuthorityFrm()
        {
            // 获取权限
            ICompetenceService authorityService = new CompetenceService();
            _competenceList = authorityService.FindList(u => u.Valid, "CompetenceID", true).ToList();

            // 获取用户
            IUserService userService = new UserService();

            var userQueryable = userService.FindList(u => true, "czy", true);

            var userList = userQueryable.ToList();

            InitializeComponent();

            combUser.DataSource = userList;
            combUser.DisplayMember = "czy";
        }

        private void AuthorityFrm_Load(object sender, EventArgs e)
        {
            tvCompetence.Nodes.Clear();
            BindTree();
        }

        private void tvCompetence_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action == TreeViewAction.Unknown)
            {
                return;
            }
            _curUser = (password)combUser.SelectedItem;

            //选中(取消选中)父节点，选中(取消选中)该节点下面的子结点
            CheckAllChildNodes(e.Node, e.Node.Checked);
            //选中(取消选中)子节点,选中(取消选中)该节点的父结点  
            CheckAllParentNodes(e.Node, e.Node.Checked);
        }

        private void combUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            _curUser = (password)combUser.SelectedItem;
            _curUserCompetence = _curUser.CompetenceSet.Select(u => u.CompetenceID).ToList();
            SetNode(tvCompetence.Nodes);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Enabled = false;

            IUserService userService = new UserService();

            MessageBox.Show(userService.Update(_curUser) ? "更新成功！" : "更新失败！");

            Enabled = true;
        }
        #endregion

        #region 自定义方法
        /// <summary>
        /// 创建权限树
        /// </summary>
        public void BindTree()
        {

            var userCurrent = (password)combUser.SelectedItem;

            var userCompetence = userCurrent.CompetenceSet.Select(u=>u.CompetenceName).ToArray();

            var firstNodes = _competenceList.Where(u => u.CompetenceParentID == null).ToList();
            _childNodes = _competenceList.Where(u => u.CompetenceParentID != null).ToList();

            foreach (var treeNode in firstNodes.Select(item => new TreeNode {Text = item.CompetenceName, Tag = item.CompetenceID}))
            {
                tvCompetence.Nodes.Add(treeNode);

                if (userCompetence.Contains(treeNode.Text))
                {
                    treeNode.Checked = true;
                }

                CreateChildNodes(treeNode, userCompetence);
            }

            _childNodes = null;
        }

        /// <summary>
        /// 创建子节点
        /// </summary>
        /// <param name="parentNode">父节点</param>
        /// <param name="competenceArray">权限组</param>
        public void CreateChildNodes(TreeNode parentNode, string[] competenceArray)
        {
            foreach (var tnChild in from item in _childNodes where parentNode.Tag.Equals(item.CompetenceParentID) select new TreeNode { Text = item.CompetenceName, Tag = item.CompetenceID })
            {
                parentNode.Nodes.Add(tnChild);

                if (competenceArray.Contains(tnChild.Text))
                {
                    tnChild.Checked = true;
                }

                CreateChildNodes(tnChild, competenceArray);
            }
        }

        /// <summary>
        /// 选中(取消选中)父节点，选中(取消选中)该节点下面的子结点  
        /// </summary>
        /// <param name="tnParent"></param>
        /// <param name="nodeChk"></param>
        public void CheckAllChildNodes(TreeNode tnParent, bool nodeChk)
        {
            if (0 == tnParent.Nodes.Count)
            {
                return;
            }

            // 根据节点的状态，判断添加或移除该节点
            ChangeUserCompetence(tnParent, nodeChk);

            foreach (TreeNode item in tnParent.Nodes)
            {
                item.Checked = nodeChk;

                // 根据节点的状态，判断添加或移除该节点
                ChangeUserCompetence(item, nodeChk);
                
                CheckAllChildNodes(item, nodeChk);  
            }
        }

        /// <summary>
        /// 选中(取消选中)子节点,选中(取消选中)该节点的父结点  
        /// </summary>
        /// <param name="tnChild"></param>
        /// <param name="nodeChk"></param>
        public void CheckAllParentNodes(TreeNode tnChild, bool nodeChk)
        {
            if (tnChild.Parent != null)
            {
                // 设置父节点是否选中
                tnChild.Parent.Checked = HasParentNode(tnChild.Parent);

                // 根据父节点的状态，判断是否移除
                ChangeUserCompetence(tnChild.Parent, tnChild.Parent.Checked);

                CheckAllParentNodes(tnChild.Parent, nodeChk);  
            }
        }

        /// <summary>
        /// 根据当前子节点的状态，选中或不选中父节点
        /// </summary>
        /// <param name="tnChild"></param>
        /// <returns></returns>
        public bool HasParentNode(TreeNode tnChild)
        {
            foreach (TreeNode item in tnChild.Nodes)
            {
                if (item.Checked)
                {
                    return true;
                }
                HasParentNode(item);  
            }
            return false;  
        }

        /// <summary>
        /// 根据节点的状态，添加或删除该节点
        /// </summary>
        /// <param name="treeNode"></param>
        /// <param name="nodeChk"></param>
        public void ChangeUserCompetence(TreeNode treeNode, bool nodeChk)
        {
            var bExist = _curUser.CompetenceSet.Select(u => u.CompetenceID).ToList().Contains(int.Parse(treeNode.Tag.ToString()));

            if (nodeChk)
            {
                if (!bExist)
                {
                    _curUser.CompetenceSet.Add(_competenceList.First(u => u.CompetenceID.Equals(treeNode.Tag)));
                }
            }
            else
            {
                if (bExist)
                {
                    _curUser.CompetenceSet.Remove(_curUser.CompetenceSet.First(u => u.CompetenceID.Equals(treeNode.Tag)));
                }
            }
        }

        /// <summary>
        /// 遍历TreeView中所有选中节点  
        /// 然后将选中的RoleCode插入到ArrayList中
        /// </summary>
        /// <param name="tc"></param>
        public void GetNode(TreeNodeCollection tc)
        {
           
            foreach (TreeNode node in tc)
            {
                //if (node.Checked && node.Text != "全选")
                //{
                //    _userCompetenceList.Add(new UserCompetence
                //    {
                //        CompetenceID = int.Parse(node.Tag.ToString()),
                //        gh = combUser.Tag.ToString()
                //    });
                //}
                GetNode(node.Nodes);
            }
        }

        /// <summary>
        /// 设置节点选中与否
        /// </summary>
        /// <param name="tc"></param>
        public void SetNode(TreeNodeCollection tc)
        {
            foreach (TreeNode node in tc)
            {
                node.Checked = _curUserCompetence.Contains(int.Parse(node.Tag.ToString()));

                SetNode(node.Nodes);
            }
        }
        #endregion
    }
}
