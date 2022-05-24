
namespace TEST
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.NAME = new System.Windows.Forms.Label();
            this.YEAR = new System.Windows.Forms.Label();
            this.PRICE = new System.Windows.Forms.Label();
            this.DOOR = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_modi = new System.Windows.Forms.Button();
            this.btn_condsearch = new System.Windows.Forms.Button();
            this.btn_wholeSearch = new System.Windows.Forms.Button();
            this.txt_year = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_door = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NAME
            // 
            this.NAME.AutoSize = true;
            this.NAME.Location = new System.Drawing.Point(12, 187);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(33, 12);
            this.NAME.TabIndex = 1;
            this.NAME.Text = "이 름";
            // 
            // YEAR
            // 
            this.YEAR.AutoSize = true;
            this.YEAR.Location = new System.Drawing.Point(12, 215);
            this.YEAR.Name = "YEAR";
            this.YEAR.Size = new System.Drawing.Size(33, 12);
            this.YEAR.TabIndex = 1;
            this.YEAR.Text = "년 식";
            // 
            // PRICE
            // 
            this.PRICE.AutoSize = true;
            this.PRICE.Location = new System.Drawing.Point(12, 244);
            this.PRICE.Name = "PRICE";
            this.PRICE.Size = new System.Drawing.Size(33, 12);
            this.PRICE.TabIndex = 1;
            this.PRICE.Text = "가 격";
            // 
            // DOOR
            // 
            this.DOOR.AutoSize = true;
            this.DOOR.Location = new System.Drawing.Point(12, 273);
            this.DOOR.Name = "DOOR";
            this.DOOR.Size = new System.Drawing.Size(33, 12);
            this.DOOR.TabIndex = 1;
            this.DOOR.Text = "도 어";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(349, 182);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "저장";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_modi
            // 
            this.btn_modi.Location = new System.Drawing.Point(349, 210);
            this.btn_modi.Name = "btn_modi";
            this.btn_modi.Size = new System.Drawing.Size(75, 23);
            this.btn_modi.TabIndex = 2;
            this.btn_modi.Text = "수정";
            this.btn_modi.UseVisualStyleBackColor = true;
            this.btn_modi.Click += new System.EventHandler(this.btn_modi_Click);
            // 
            // btn_condsearch
            // 
            this.btn_condsearch.Location = new System.Drawing.Point(349, 239);
            this.btn_condsearch.Name = "btn_condsearch";
            this.btn_condsearch.Size = new System.Drawing.Size(75, 23);
            this.btn_condsearch.TabIndex = 2;
            this.btn_condsearch.Text = "조건검색";
            this.btn_condsearch.UseVisualStyleBackColor = true;
            this.btn_condsearch.Click += new System.EventHandler(this.btn_condsearch_Click);
            // 
            // btn_wholeSearch
            // 
            this.btn_wholeSearch.Location = new System.Drawing.Point(349, 268);
            this.btn_wholeSearch.Name = "btn_wholeSearch";
            this.btn_wholeSearch.Size = new System.Drawing.Size(75, 23);
            this.btn_wholeSearch.TabIndex = 2;
            this.btn_wholeSearch.Text = "전체검색";
            this.btn_wholeSearch.UseVisualStyleBackColor = true;
            this.btn_wholeSearch.Click += new System.EventHandler(this.btn_wholeSearch_Click);
            // 
            // txt_year
            // 
            this.txt_year.Location = new System.Drawing.Point(63, 212);
            this.txt_year.Name = "txt_year";
            this.txt_year.Size = new System.Drawing.Size(100, 21);
            this.txt_year.TabIndex = 3;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(63, 241);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(100, 21);
            this.txt_price.TabIndex = 3;
            // 
            // txt_door
            // 
            this.txt_door.Location = new System.Drawing.Point(63, 270);
            this.txt_door.Name = "txt_door";
            this.txt_door.Size = new System.Drawing.Size(100, 21);
            this.txt_door.TabIndex = 3;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(63, 184);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 21);
            this.txt_name.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(412, 163);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.삭제ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(99, 26);
            // 
            // 삭제ToolStripMenuItem
            // 
            this.삭제ToolStripMenuItem.Name = "삭제ToolStripMenuItem";
            this.삭제ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.삭제ToolStripMenuItem.Text = "삭제";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 303);
            this.Controls.Add(this.txt_door);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_year);
            this.Controls.Add(this.btn_wholeSearch);
            this.Controls.Add(this.btn_condsearch);
            this.Controls.Add(this.btn_modi);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.DOOR);
            this.Controls.Add(this.PRICE);
            this.Controls.Add(this.YEAR);
            this.Controls.Add(this.NAME);
            this.Controls.Add(this.listView1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "차량 정보 관리 프로그램";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NAME;
        private System.Windows.Forms.Label YEAR;
        private System.Windows.Forms.Label PRICE;
        private System.Windows.Forms.Label DOOR;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_modi;
        private System.Windows.Forms.Button btn_condsearch;
        private System.Windows.Forms.Button btn_wholeSearch;
        private System.Windows.Forms.TextBox txt_year;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_door;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 삭제ToolStripMenuItem;
    }
}

