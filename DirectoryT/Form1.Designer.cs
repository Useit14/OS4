
namespace DirectoryT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.SortBox = new System.Windows.Forms.ComboBox();
            this.Path_panel = new System.Windows.Forms.Panel();
            this.Search_textBox = new System.Windows.Forms.TextBox();
            this.Path_tb = new System.Windows.Forms.TextBox();
            this.Up_button = new System.Windows.Forms.Button();
            this.Left_button = new System.Windows.Forms.Button();
            this.Right_button = new System.Windows.Forms.Button();
            this.Lower_panel = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.Search_ListView = new System.Windows.Forms.ListView();
            this.Name_tb = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenuCreate = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Create_bt = new System.Windows.Forms.ToolStripMenuItem();
            this.File_bt = new System.Windows.Forms.ToolStripMenuItem();
            this.Folder_bt = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete_bt = new System.Windows.Forms.ToolStripMenuItem();
            this.Duplicate_bt = new System.Windows.Forms.ToolStripMenuItem();
            this.Rename_bt = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PastMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Path_panel.SuspendLayout();
            this.Lower_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuCreate.SuspendLayout();
            this.SuspendLayout();
            // 
            // SortBox
            // 
            this.SortBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SortBox.FormattingEnabled = true;
            this.SortBox.Items.AddRange(new object[] {
            "Имени",
            "Типу",
            "Размеру"});
            this.SortBox.Location = new System.Drawing.Point(509, 10);
            this.SortBox.Name = "SortBox";
            this.SortBox.Size = new System.Drawing.Size(150, 28);
            this.SortBox.TabIndex = 0;
            this.SortBox.Text = "Сортировка";
            this.SortBox.SelectedIndexChanged += new System.EventHandler(this.SortBox_SelectedIndexChanged);
            // 
            // Path_panel
            // 
            this.Path_panel.BackColor = System.Drawing.SystemColors.Control;
            this.Path_panel.Controls.Add(this.SortBox);
            this.Path_panel.Controls.Add(this.Search_textBox);
            this.Path_panel.Controls.Add(this.Path_tb);
            this.Path_panel.Controls.Add(this.Up_button);
            this.Path_panel.Controls.Add(this.Left_button);
            this.Path_panel.Controls.Add(this.Right_button);
            this.Path_panel.Location = new System.Drawing.Point(0, 0);
            this.Path_panel.Name = "Path_panel";
            this.Path_panel.Size = new System.Drawing.Size(897, 49);
            this.Path_panel.TabIndex = 2;
            // 
            // Search_textBox
            // 
            this.Search_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Search_textBox.Location = new System.Drawing.Point(666, 11);
            this.Search_textBox.Name = "Search_textBox";
            this.Search_textBox.Size = new System.Drawing.Size(219, 27);
            this.Search_textBox.TabIndex = 4;
            this.Search_textBox.Text = "Поиск ";
            this.Search_textBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Search_textBox_MouseClick);
            this.Search_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_textBox_KeyDown);
            // 
            // Path_tb
            // 
            this.Path_tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Path_tb.Location = new System.Drawing.Point(145, 11);
            this.Path_tb.Margin = new System.Windows.Forms.Padding(0);
            this.Path_tb.Name = "Path_tb";
            this.Path_tb.Size = new System.Drawing.Size(358, 27);
            this.Path_tb.TabIndex = 3;
            // 
            // Up_button
            // 
            this.Up_button.Location = new System.Drawing.Point(97, 11);
            this.Up_button.Name = "Up_button";
            this.Up_button.Size = new System.Drawing.Size(27, 27);
            this.Up_button.TabIndex = 2;
            this.Up_button.Text = "Up";
            this.Up_button.UseVisualStyleBackColor = true;
            this.Up_button.Click += new System.EventHandler(this.Up_button_Click);
            // 
            // Left_button
            // 
            this.Left_button.Location = new System.Drawing.Point(12, 11);
            this.Left_button.Margin = new System.Windows.Forms.Padding(0);
            this.Left_button.Name = "Left_button";
            this.Left_button.Size = new System.Drawing.Size(27, 27);
            this.Left_button.TabIndex = 1;
            this.Left_button.Text = "Left";
            this.Left_button.UseVisualStyleBackColor = true;
            this.Left_button.Click += new System.EventHandler(this.Left_button_Click);
            // 
            // Right_button
            // 
            this.Right_button.Location = new System.Drawing.Point(55, 11);
            this.Right_button.Name = "Right_button";
            this.Right_button.Size = new System.Drawing.Size(27, 27);
            this.Right_button.TabIndex = 0;
            this.Right_button.Text = "Right";
            this.Right_button.UseVisualStyleBackColor = true;
            this.Right_button.Click += new System.EventHandler(this.Right_button_Click);
            // 
            // Lower_panel
            // 
            this.Lower_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lower_panel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Lower_panel.Controls.Add(this.splitContainer1);
            this.Lower_panel.Location = new System.Drawing.Point(0, 87);
            this.Lower_panel.Margin = new System.Windows.Forms.Padding(0);
            this.Lower_panel.Name = "Lower_panel";
            this.Lower_panel.Size = new System.Drawing.Size(897, 448);
            this.Lower_panel.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            this.splitContainer1.Panel1MinSize = 50;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Search_ListView);
            this.splitContainer1.Panel2.Controls.Add(this.Name_tb);
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Panel2MinSize = 300;
            this.splitContainer1.Size = new System.Drawing.Size(897, 448);
            this.splitContainer1.SplitterDistance = 147;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Node1";
            treeNode2.Name = "Node0";
            treeNode2.Text = "Node0";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treeView1.Size = new System.Drawing.Size(147, 448);
            this.treeView1.TabIndex = 0;
            this.treeView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDoubleClick);
            // 
            // Search_ListView
            // 
            this.Search_ListView.HideSelection = false;
            this.Search_ListView.Location = new System.Drawing.Point(559, 108);
            this.Search_ListView.Name = "Search_ListView";
            this.Search_ListView.Size = new System.Drawing.Size(151, 121);
            this.Search_ListView.TabIndex = 1;
            this.Search_ListView.UseCompatibleStateImageBehavior = false;
            this.Search_ListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Search_ListView_MouseDoubleClick);
            // 
            // Name_tb
            // 
            this.Name_tb.Location = new System.Drawing.Point(609, 25);
            this.Name_tb.Name = "Name_tb";
            this.Name_tb.Size = new System.Drawing.Size(125, 27);
            this.Name_tb.TabIndex = 1;
            this.Name_tb.TextChanged += new System.EventHandler(this.Name_tb_TextChanged);
            this.Name_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Name_tb_KeyDown);
            this.Name_tb.Leave += new System.EventHandler(this.Name_tb_Leave);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.ContextMenuStrip = this.contextMenuCreate;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(746, 448);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // contextMenuCreate
            // 
            this.contextMenuCreate.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuCreate.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Create_bt,
            this.Delete_bt,
            this.Duplicate_bt,
            this.Rename_bt,
            this.CopyMenuItem,
            this.PastMenuItem,
            this.CutToolStripMenuItem});
            this.contextMenuCreate.Name = "contextMenuStrip1";
            this.contextMenuCreate.Size = new System.Drawing.Size(211, 200);
            this.contextMenuCreate.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuCreate_Opening);
            // 
            // Create_bt
            // 
            this.Create_bt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_bt,
            this.Folder_bt});
            this.Create_bt.Name = "Create_bt";
            this.Create_bt.Size = new System.Drawing.Size(210, 24);
            this.Create_bt.Text = "Создать";
            // 
            // File_bt
            // 
            this.File_bt.Name = "File_bt";
            this.File_bt.Size = new System.Drawing.Size(134, 26);
            this.File_bt.Text = "Файл";
            this.File_bt.Click += new System.EventHandler(this.File_bt_Click);
            // 
            // Folder_bt
            // 
            this.Folder_bt.Name = "Folder_bt";
            this.Folder_bt.Size = new System.Drawing.Size(134, 26);
            this.Folder_bt.Text = "Папку";
            this.Folder_bt.Click += new System.EventHandler(this.Folder_bt_Click);
            // 
            // Delete_bt
            // 
            this.Delete_bt.Name = "Delete_bt";
            this.Delete_bt.Size = new System.Drawing.Size(210, 24);
            this.Delete_bt.Text = "Удалить";
            this.Delete_bt.Click += new System.EventHandler(this.Delete_bt_Click);
            // 
            // Duplicate_bt
            // 
            this.Duplicate_bt.Name = "Duplicate_bt";
            this.Duplicate_bt.Size = new System.Drawing.Size(210, 24);
            this.Duplicate_bt.Text = "Дублировать";
            this.Duplicate_bt.Click += new System.EventHandler(this.Duplicate_bt_Click);
            // 
            // Rename_bt
            // 
            this.Rename_bt.Name = "Rename_bt";
            this.Rename_bt.Size = new System.Drawing.Size(210, 24);
            this.Rename_bt.Text = "Переименовать";
            this.Rename_bt.Click += new System.EventHandler(this.Rename_bt_Click);
            // 
            // CopyMenuItem
            // 
            this.CopyMenuItem.Name = "CopyMenuItem";
            this.CopyMenuItem.Size = new System.Drawing.Size(210, 24);
            this.CopyMenuItem.Text = "Копировать";
            this.CopyMenuItem.Click += new System.EventHandler(this.CopyMenuItem_Click);
            // 
            // PastMenuItem
            // 
            this.PastMenuItem.Name = "PastMenuItem";
            this.PastMenuItem.Size = new System.Drawing.Size(210, 24);
            this.PastMenuItem.Text = "Вставить";
            this.PastMenuItem.Click += new System.EventHandler(this.PastMenuItem_Click);
            // 
            // CutToolStripMenuItem
            // 
            this.CutToolStripMenuItem.Name = "CutToolStripMenuItem";
            this.CutToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.CutToolStripMenuItem.Text = "Вырезать";
            this.CutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 536);
            this.Controls.Add(this.Lower_panel);
            this.Controls.Add(this.Path_panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Path_panel.ResumeLayout(false);
            this.Path_panel.PerformLayout();
            this.Lower_panel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuCreate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Path_panel;
        private System.Windows.Forms.Panel Lower_panel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button Right_button;
        private System.Windows.Forms.Button Left_button;
        private System.Windows.Forms.Button Up_button;
        private System.Windows.Forms.TextBox Search_textBox;
        private System.Windows.Forms.TextBox Path_tb;
        private System.Windows.Forms.ComboBox SortBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuCreate;
        private System.Windows.Forms.ToolStripMenuItem Create_bt;
        private System.Windows.Forms.ToolStripMenuItem File_bt;
        private System.Windows.Forms.ToolStripMenuItem Folder_bt;
        private System.Windows.Forms.ToolStripMenuItem Delete_bt;
        private System.Windows.Forms.ToolStripMenuItem Duplicate_bt;
        private System.Windows.Forms.ToolStripMenuItem Rename_bt;
        private System.Windows.Forms.TextBox Name_tb;
        private System.Windows.Forms.ListView Search_ListView;
        private System.Windows.Forms.ToolStripMenuItem CopyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PastMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CutToolStripMenuItem;
    }
}

