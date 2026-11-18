using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Черновик_памяти
{
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();
            // Включаем чекбоксы для TreeView
            treeView1.CheckBoxes = true;

            // Подписываемся на событие изменения состояния чекбокса
            treeView1.AfterCheck += treeView1_AfterCheck;

            // Заполняем дерево тестовыми данными
            LoadTreeData();
        }
        private void LoadTreeData()
        {
            TreeNode parentNode = new TreeNode("Общеупотребительные слова") { Tag = 100000 };
            parentNode.Nodes.Add(new TreeNode("ДОМ И КВАРТИРА") { Tag = 100001 });
            parentNode.Nodes.Add(new TreeNode("ЖИВОТНЫЕ") { Tag = 100002 });
            parentNode.Nodes.Add(new TreeNode("ЕДА И НАПИТКИ") { Tag = 100003 });
            parentNode.Nodes.Add(new TreeNode("ЦВЕТА") { Tag = 100004 });
            parentNode.Nodes.Add(new TreeNode("ОДЕЖДА") { Tag = 100005 });
            parentNode.Nodes.Add(new TreeNode("ТРАНСПОРТ") { Tag = 100006 });
            parentNode.Nodes.Add(new TreeNode("ПРОФЕССИИ") { Tag = 100007 });
            parentNode.Nodes.Add(new TreeNode("ЧАСТИ ТЕЛА") { Tag = 100008 });
            parentNode.Nodes.Add(new TreeNode("ЭМОЦИИ") { Tag = 100009 });
            parentNode.Nodes.Add(new TreeNode("ПОГОДА") { Tag = 100010 });
            parentNode.Nodes.Add(new TreeNode("ВРЕМЯ") { Tag = 100011 });
            parentNode.Nodes.Add(new TreeNode("ШКОЛА") { Tag = 100012 });
            parentNode.Nodes.Add(new TreeNode("МЕДИЦИНА") { Tag = 100013 });
            parentNode.Nodes.Add(new TreeNode("СРАЖЕНИЯ") { Tag = 100014 });
            parentNode.Nodes.Add(new TreeNode("ЕДА (БЛЮДА)") { Tag = 100015 });
            parentNode.Nodes.Add(new TreeNode("НАПИТКИ") { Tag = 100016 });
            parentNode.Nodes.Add(new TreeNode("МУЗЫКА") { Tag = 100017 });
            parentNode.Nodes.Add(new TreeNode("РЕЛИГИЯ") { Tag = 100018 });
            parentNode.Nodes.Add(new TreeNode("СЯНЬСЯ-ТЕРМИНЫ") { Tag = 100019 });
            parentNode.Nodes.Add(new TreeNode("Природа растения") { Tag = 100020 });
            parentNode.Nodes.Add(new TreeNode("ФИНАНСЫ") { Tag = 100021 });
            parentNode.Nodes.Add(new TreeNode("ПУТЕШЕСТВИЯ") { Tag = 100022 });
            parentNode.Nodes.Add(new TreeNode("ОРУЖИЕ И ТЕХНИКИ") { Tag = 100023 });
            parentNode.Nodes.Add(new TreeNode("ТИТУЛЫ") { Tag = 100024 });
            parentNode.Nodes.Add(new TreeNode("ЧУВСТВА") { Tag = 100025 });
            TreeNode parentNode1 = new TreeNode("Слова из различных текстов") { Tag = 200000 };
            parentNode1.Nodes.Add(new TreeNode("1") { Tag = 200001 });
            parentNode1.Nodes.Add(new TreeNode("2") { Tag = 200002 });
            parentNode1.Nodes.Add(new TreeNode("3") { Tag = 200003 });
            parentNode1.Nodes.Add(new TreeNode("4") { Tag = 200004 });
            parentNode1.Nodes.Add(new TreeNode("5") { Tag = 200005 });
            parentNode1.Nodes.Add(new TreeNode("6") { Tag = 200006 });
            parentNode1.Nodes.Add(new TreeNode("7") { Tag = 200007 });
            parentNode1.Nodes.Add(new TreeNode("8") { Tag = 200008 });
            parentNode1.Nodes.Add(new TreeNode("9") { Tag = 200009 });
            parentNode1.Nodes.Add(new TreeNode("10") { Tag = 200010 });
            parentNode1.Nodes.Add(new TreeNode("11 ") { Tag = 200011 });
            parentNode1.Nodes.Add(new TreeNode("12") { Tag = 200012 });



            treeView1.Nodes.Add(parentNode);
            treeView1.Nodes.Add(parentNode1);


            treeView1.ExpandAll();
        }

        // Флаг для предотвращения бесконечной рекурсии при программном изменении Checked
        private bool isUpdating = false;

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (isUpdating) return;

            try
            {
                isUpdating = true;
                // Устанавливаем такое же состояние для всех дочерних узлов
                CheckAllChildren(e.Node, e.Node.Checked);
            }
            finally
            {
                isUpdating = false;
            }
        }

        private void CheckAllChildren(TreeNode node, bool isChecked)
        {
            foreach (TreeNode child in node.Nodes)
            {
                child.Checked = isChecked;
                CheckAllChildren(child, isChecked); // Рекурсивно для вложенных узлов
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FindActiveNode(treeView1.Nodes) != null)
            {
                if (this.MdiParent is Form1_roditel parent)
                {
                    var existingForm3 = parent.MdiChildren.OfType<Form3>().FirstOrDefault();
                    if (existingForm3 != null)
                    {
                        existingForm3.Close();
                    }
                    {
                        Form3 form3Form = new Form3(this);
                        form3Form.MdiParent = parent;
                        form3Form.FormBorderStyle = FormBorderStyle.None;
                        form3Form.Dock = DockStyle.Fill; // Занимает всё пространство
                        form3Form.Show();
                    }
                }
                this.Hide();
                
            }
            else
                MessageBox.Show($"Выберите хотя бы одну категорию");
        }
        public TreeNode FindNodeByTag(TreeNodeCollection nodes, object tag)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Tag != null && node.Tag.Equals(tag))
                    return node;

                // Рекурсивный поиск в дочерних узлах
                TreeNode found = FindNodeByTag(node.Nodes, tag);
                if (found != null)
                    return found;
            }
            return null;
        }
        // Преобразует дерево в плоскую последовательность
        TreeNode FindActiveNode(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                // Проверяем условие «активности» (например, отмечен чекбокс)
                if (node.Checked)
                {
                    return node; // Возвращаем первый найденный
                }

                // Ищем в дочерних элементах
                TreeNode foundChild = FindActiveNode(node.Nodes);
                if (foundChild != null)
                {
                    return foundChild;
                }
            }
            return null; // Если ничего не найдено
        }

    }
}
