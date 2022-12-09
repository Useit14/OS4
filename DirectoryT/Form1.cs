using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectoryT
{
    public partial class Form1 : Form
    {
        Folder Root;
        Folder ActiveFolder;
        int countMove=0;
        List<MyObject> searchList;
        
        ActionNode actionNode = new ActionNode();
        ActionNode FirstNode = new ActionNode();

        public Form1()
        {
            InitializeComponent();
            AddPicture();
            Start();
        }
        private void Start()    //при старте 
        {
            
            this.ActiveControl = Up_button;

            Root = new Folder();
            Folder C = new Folder("C:", Root);
            ActiveFolder = Root;

            listView1.View = View.Details;
            listView1.FullRowSelect = true; // Получает или задает значение, указывающее, выбираются ли при щелчке элемента все его подэлементы.
            listView1.MultiSelect = true;

            Search_ListView.View = View.Details;
            Search_ListView.FullRowSelect = true;
            Search_ListView.MultiSelect = false;

            listView1.Columns.Add("Имя", Convert.ToInt32(listView1.Width * 0.3));      //Add column header
            listView1.Columns.Add("Тип", Convert.ToInt32(listView1.Width * 0.1));      //Add column header
            listView1.Columns.Add("Вес", Convert.ToInt32(listView1.Width * 0.1));    //Add column header

            Search_ListView.Columns.Add("Name", Convert.ToInt32(listView1.Width * 0.3));      //Add column header
            Search_ListView.Columns.Add("Type", Convert.ToInt32(listView1.Width * 0.1));      //Add column header
            Search_ListView.Columns.Add("Weight", Convert.ToInt32(listView1.Width * 0.1));

            Hide(Name_tb);
            Hide(Search_ListView);

            actionNode.folder = Root;
            
            UpdateForm();

            
        }

        private void AddPicture()   // добавление картинок 
        {
            ImageList imageForButton = new ImageList();
            imageForButton.Images.Add(Bitmap.FromFile(@"Picture\Right.png"));// стрелка вправо
            imageForButton.Images.Add(Bitmap.FromFile(@"Picture\Left.png"));// стрелка влево
            imageForButton.Images.Add(Bitmap.FromFile(@"Picture\Up.png"));// стрелка вверх
            imageForButton.ImageSize = new Size(18, 18);

            ImageList imageListSmall = new ImageList();
            imageListSmall.Images.Add(Bitmap.FromFile(@"Picture\Folder.png"));
            imageListSmall.Images.Add(Bitmap.FromFile(@"Picture\File.png"));
            imageListSmall.ImageSize = new Size(32, 32);

            listView1.SmallImageList = imageListSmall;
            Search_ListView.SmallImageList = imageListSmall;

            Right_button.Image = imageForButton.Images[0];
            Right_button.Text = "";
            Right_button.Enabled = false;

            Left_button.Image = imageForButton.Images[1];
            Left_button.Text = "";
            Left_button.Enabled = false;

            Up_button.Image = imageForButton.Images[2];
            Up_button.Text = "";
            Up_button.Enabled = false;
        }

        private void Hide(Control obj) //спрятать элемент 
        {
            obj.Visible = false;
            obj.Enabled = false;
        } 
        private void Hide(ToolStripMenuItem obj)    //спрятать элемент 
        {
            obj.Visible = false;
            obj.Enabled = false;
        }
        private void Seek(Control obj)  //показать элемент 
        {
            obj.Visible = true;
            obj.Enabled = true;
        }
        private void Seek(ToolStripMenuItem obj)    //показать элемент 
        {
            obj.Visible = true;
            obj.Enabled = true;
        }

        private void LeftBt()
        {
            if (actionNode.Prev!=null )
            {
                Left_button.Enabled = true;
            }
            else
            {
                Left_button.Enabled = false;
            }
        } // доделать

        private void RightBt()
        {
            if (actionNode.Next != null)
            {
                Right_button.Enabled = true;
            }
            else
            {
                Right_button.Enabled = false;
            }
        } // доделать

        private void UpdateForm() // обновить "форму" 
        {
            int indexImage;
            if (ActiveFolder != Root)
            {
                Up_button.Enabled = true;
            }
            else
            {
                Up_button.Enabled = false;
            }
            LeftBt();
            RightBt();
            Search_textBox.Text = $"Поиск в: {ActiveFolder._Name}";
            Path_tb.Text = ActiveFolder._Path;
            listView1.Items.Clear();
            string[] arr = new string[3];
            foreach (MyObject obj in ActiveFolder.Return_Children())
            {
                arr[0] = obj._Name;
                var a = obj.GetType().ToString();
                if (obj is Folder)
                {

                    arr[1] = "Folder";
                    arr[2] = "";
                    indexImage = 0;
                }
                else
                {
                    File file = obj as File;
                    arr[1] = "File";
                    arr[2] = file._Weight.ToString();
                    indexImage = 1;
                }
                listView1.Items.Add(arr[0], indexImage);
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(arr[1]);
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(arr[2]);

            }
            TreeUpdate();
        }

        private void TreeUpdate() // обновить "дерево" 
        {
            treeView1.Nodes.Clear();
            treeView1.BeginUpdate();
            TreeNodes(Root, treeView1.Nodes);
            treeView1.EndUpdate();
        }
        private void TreeNodes(Folder Parent, TreeNodeCollection nodes)  // обновить "дерево" рекурсия 
        {
            var Children = Parent.Return_Children();
            foreach (MyObject child in Children)
            {
                int CountNodes = 0;
                if (child is Folder)
                {
                    nodes.Add(child._Name);
                    TreeNodes(child as Folder, nodes[CountNodes].Nodes);
                    CountNodes++;
                }
            }
        }

        private void File_bt_Click(object sender, EventArgs e) // кнопка создания файла 
        {
            Random rnd = new Random();
            try
            {
                MyObject newFile = new File("новый файл", ActiveFolder, rnd.Next(10, 500));
                UpdateForm();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }

        private void Folder_bt_Click(object sender, EventArgs e) // кнопка создать папку 
        {
            try
            {
                MyObject newFolder = new Folder("новая папка", ActiveFolder);
                UpdateForm();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }  

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e) // двойное нажатие по элементу 
        {
            var index = listView1.FocusedItem.Index;
            ActionNode current = new ActionNode();
            MyObject child = ActiveFolder.Return_Children()[index];
            if (child is Folder)
            {
                ActiveFolder = child as Folder;


                current.folder = child as Folder;
                current.Prev = actionNode;
                actionNode.Next = current;
                actionNode = current;


                
                UpdateForm();
            }
            else
            {
                MessageBox.Show($"The <<{child._Name}>> file has been opened");
            }
        } 

        private void Up_button_Click(object sender, EventArgs e) // Вверх по дереву 
        {
            if (ActiveFolder._Parent != null)
            {
                ActiveFolder = ActiveFolder._Parent as Folder;
                UpdateForm();
            }
        } 

        private void Left_button_Click(object sender, EventArgs e) // шаг назад
        {
            actionNode = actionNode.Prev;
            ActiveFolder = actionNode.folder;
            UpdateForm();
        } // доделать

        private void Right_button_Click(object sender, EventArgs e) // шаг вперед
        {
            actionNode = actionNode.Next;
            ActiveFolder = actionNode.folder;
            UpdateForm();
        } // доделать

        private void contextMenuCreate_Opening(object sender, CancelEventArgs e) //правая кнопка мыши 
        {

            if (listView1.SelectedItems.Count != 0)
            {
                Hide(Create_bt);
                Hide(PastMenuItem);
                Seek(Delete_bt);
                Seek(Duplicate_bt);
                Seek(Rename_bt);
                Seek(CopyMenuItem);
                Seek(CutToolStripMenuItem);
            }
            else
            {
                Seek(Create_bt);
                Seek(PastMenuItem);
                Hide(Delete_bt);
                Hide(Duplicate_bt);
                Hide(Rename_bt);
                Hide(CopyMenuItem);
                Hide(CutToolStripMenuItem);
            }
        }

        private void Duplicate_bt_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                var index = listView1.FocusedItem.Index;
                MyObject child = ActiveFolder.Return_Children()[index];
                var name = child._Name + " — Копия " + child.CountIs;
                child.CountIs++;

                if (child is Folder)
                {
                    Folder select = child as Folder;
                    try
                    {
                        Folder Duplicate = new Folder(name, ActiveFolder);
                        List<MyObject> list = new List<MyObject>();
                        foreach (MyObject obj in select.Return_Children())
                        {
                            DuplicateFunction(obj, obj._Name, Duplicate);
                        }

                    }
                    catch (Exception excep)
                    {
                        MessageBox.Show(excep.Message);
                    }
                }
                else
                {
                    File select = child as File;
                    try
                    {
                        MyObject newFile = new File(name, ActiveFolder, select._Weight);
                    }
                    catch (Exception excep)
                    {
                        MessageBox.Show(excep.Message);
                    }
                }

                UpdateForm();
            }
        }

        private void DuplicateFunction(MyObject child, string name, Folder parent)
        {
            if (child is Folder)
            {
                Folder select = child as Folder;
                try
                {
                    Folder Duplicate = new Folder(name, parent);
                    List<MyObject> list = new List<MyObject>();
                    foreach (MyObject obj in select.Return_Children())
                    {
                        DuplicateFunction(obj, name, Duplicate);
                    }

                }
                catch (Exception excep)
                {
                    MessageBox.Show(excep.Message);
                }
            }
            else
            {
                File select = child as File;
                try
                {
                    MyObject newFile = new File(name, parent, select._Weight);
                }
                catch (Exception excep)
                {
                    MessageBox.Show(excep.Message);
                }
            }
        }

        private void Delete_bt_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                var a = listView1.SelectedItems;
                for (int i = 0; i < a.Count; i++)
                {
                    try
                    {
                        ActiveFolder.Delete_Child(a[i].Index - i);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                UpdateForm();
            }
        }

        private void Rename_bt_Click(object sender, EventArgs e)
        {
            if (ActiveFolder == Root)
            {
                MessageBox.Show("Cannot be used in the root directory");
                return;
            }
            if (listView1.SelectedItems.Count != 0)
            {
                Name_tb.Location = listView1.FocusedItem.Position;
                Name_tb.Text = listView1.FocusedItem.Text;
                Name_tb.Width = Name_tb.Text.Length * 8 + 100;
                listView1.Controls.Add(Name_tb);
                Name_tb.Enabled = true;
                Name_tb.Visible = true;
                Name_tb.Focus();
                Name_tb.SelectAll();
            }
        }

        private void Name_tb_TextChanged(object sender, EventArgs e)
        {
            Name_tb.Width = Name_tb.Text.Length * 8 + 100;
        }

        private void Name_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var index = listView1.FocusedItem.Index;
                MyObject child = ActiveFolder.Return_Children()[index];
                try
                {
                    child.ReName(Name_tb.Text);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                Name_tb.Location = new Point(this.Width, 0);
                Hide(Name_tb);
                UpdateForm();
            }
        }

        private void Name_tb_Leave(object sender, EventArgs e)
        {
            var index = listView1.FocusedItem.Index;
            MyObject child = ActiveFolder.Return_Children()[index];
            try
            {
                child.ReName(Name_tb.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            Name_tb.Location = new Point(this.Width, 0);
            Hide(Name_tb);
            UpdateForm();
        }

        private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var a = treeView1.SelectedNode;
            if (a != null)
            {
                List<TreeNode> List = new List<TreeNode>();
                while (a.Parent != null)
                {
                    List.Add(a);
                    a = a.Parent;
                }
                Folder myFolder = Root.Children[0] as Folder;
                for (int i = List.Count - 1; i >= 0; i--)
                {
                    myFolder = descent(myFolder, List[i].Text);
                }
                ActiveFolder = myFolder;
                UpdateForm();
            }
            treeView1.ExpandAll();
        }

        private Folder descent(Folder Parent, string name)
        {
            Folder folder = Parent;
            foreach (MyObject obj in Parent.Children)
            {
                if (obj is Folder)
                {
                    Folder current = obj as Folder;
                    if (current._Name == name)
                    {
                        folder = current;
                    }
                }
            }
            return folder;
        }

        private void SortBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sort = SortBox.SelectedIndex;

            if (sort == 0) // name
            {
                ActiveFolder.SortByName();
            }
            if (sort == 1) // Type
            {
                ActiveFolder.SortByType();
            }
            if (sort == 2) // Weight 
            {
                ActiveFolder.SortByWeight();
            }
            UpdateForm();
        }

        private void Search_textBox_MouseClick(object sender, MouseEventArgs e)
        {
            Search_textBox.SelectAll();
        }

        private void Search_textBox_KeyDown(object sender, KeyEventArgs e) // Поиск объекта 
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (Search_textBox.Text == "")
                    {
                        Hide(Search_ListView);
                        Seek(listView1);
                        UpdateForm();
                        return;
                    }
                    searchList = new List<MyObject>();
                    foreach (MyObject obj in ActiveFolder.Return_Children())
                    {
                        Search(obj, Search_textBox.Text);
                    }
                    if (searchList.Count != 0)
                    {
                        SearchDirectory();
                    }
                    else
                    {
                        MessageBox.Show("Нет элементов");
                    }
                }
            } catch (Exception ex)
            {
                Hide(Search_ListView);
                Seek(listView1);
                UpdateForm();
            }
        }

        private void Search(MyObject obj, string Name)  // Поиск объекта (рекурсия) 
        {
            if (obj is Folder)
            {
                foreach (MyObject child in (obj as Folder).Return_Children())
                {
                    Search(child, Search_textBox.Text);
                }
            }
            if (obj._Name.ToLower().Contains(Name.ToLower()))
            {
                searchList.Add(obj);
            }
        }

        private void SearchDirectory()
        {
            
            Search_ListView.Size = listView1.Size;
            Search_ListView.Location = listView1.Location;
            Hide(listView1);

            int indexImage;

            Path_tb.Text = "";
            Search_ListView.Items.Clear();
            string[] arr = new string[3];
            foreach (MyObject obj in searchList)
            {
                arr[0] = obj._Name;
                var a = obj.GetType().ToString();
                if (obj is Folder)
                {

                    arr[1] = "Folder";
                    arr[2] = "";
                    indexImage = 0;
                }
                else
                {
                    File file = obj as File;
                    arr[1] = "File";
                    arr[2] = file._Weight.ToString();
                    indexImage = 1;
                }
                Search_ListView.Items.Add(arr[0], indexImage);
                Search_ListView.Items[searchList.Count - 1].SubItems.Add(arr[1]);
                Search_ListView.Items[searchList.Count - 1].SubItems.Add(arr[2]);

            }
            Seek(Search_ListView);
        }

        private void Search_ListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var index = Search_ListView.FocusedItem.Index;
            MyObject child = searchList[index];
            if (child is Folder)
            {
                ActiveFolder = child as Folder;
                UpdateForm();
            }
            else
            {
                ActiveFolder = child._Parent as Folder;
                UpdateForm();
            }
            Hide(Search_ListView);
            Seek(listView1);
        }

        private void CopyMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                var index = listView1.FocusedItem.Index;
                MyObject child = ActiveFolder.Return_Children()[index];
                var name = child._Name + " — Копия " + child.CountIs;
                child.CountIs++;
                Root.SetBuffer(child);
                
            }

        }

        private void PastMenuItem_Click(object sender, EventArgs e)
        {
            var child = Root.GetBuffer();
            if (child is Folder)
            {
                Folder select = child as Folder;
                try
                {
                    Folder Duplicate = new Folder(child._Name, ActiveFolder);
                    List<MyObject> list = new List<MyObject>();
                    foreach (MyObject obj in select.Return_Children())
                    {
                        DuplicateFunction(obj, obj._Name, Duplicate);
                    }

                }
                catch (Exception excep)
                {
                    MessageBox.Show(excep.Message);
                }
            }
            else
            {
                File select = child as File;
                try
                {
                    MyObject newFile = new File(child._Name, ActiveFolder, select._Weight);
                }
                catch (Exception excep)
                {
                    MessageBox.Show(excep.Message);
                }
            }
            UpdateForm();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                var index = listView1.FocusedItem.Index;
                MyObject child = ActiveFolder.Return_Children()[index];
                child.CountIs++;
                Root.SetBuffer(child);
                for (int i = 0; i < listView1.SelectedItems.Count; i++)
                {
                    try
                    {
                        ActiveFolder.Delete_Child(listView1.SelectedItems[i].Index - i);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                UpdateForm();
            }
        }
    }
}
