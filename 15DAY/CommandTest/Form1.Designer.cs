
namespace CommandTest
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.checkMale = new System.Windows.Forms.CheckBox();
            this.btnInsert1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textAge = new System.Windows.Forms.TextBox();
            this.btnInsert2 = new System.Windows.Forms.Button();
            this.checkFemale = new System.Windows.Forms.CheckBox();
            this.btnIncAllAge = new System.Windows.Forms.Button();
            this.btnIncSomeAge = new System.Windows.Forms.Button();
            this.btnRollBack = new System.Windows.Forms.Button();
            this.btnCommit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(280, 112);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(307, 12);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "SELECT";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(307, 41);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(307, 70);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(307, 99);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(75, 23);
            this.btnSum.TabIndex = 1;
            this.btnSum.Text = "SUM";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click_1);
            // 
            // checkMale
            // 
            this.checkMale.AutoSize = true;
            this.checkMale.Location = new System.Drawing.Point(251, 140);
            this.checkMale.Name = "checkMale";
            this.checkMale.Size = new System.Drawing.Size(48, 16);
            this.checkMale.TabIndex = 2;
            this.checkMale.Text = "남자";
            this.checkMale.UseVisualStyleBackColor = true;
            this.checkMale.CheckedChanged += new System.EventHandler(this.checkMale_CheckedChanged);
            // 
            // btnInsert1
            // 
            this.btnInsert1.Location = new System.Drawing.Point(12, 162);
            this.btnInsert1.Name = "btnInsert1";
            this.btnInsert1.Size = new System.Drawing.Size(75, 23);
            this.btnInsert1.TabIndex = 3;
            this.btnInsert1.Text = "INSERT1";
            this.btnInsert1.UseVisualStyleBackColor = true;
            this.btnInsert1.Click += new System.EventHandler(this.btnInsert1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "이름:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "나이:";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(51, 135);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(75, 21);
            this.textName.TabIndex = 6;
            // 
            // textAge
            // 
            this.textAge.Location = new System.Drawing.Point(171, 135);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(74, 21);
            this.textAge.TabIndex = 7;
            // 
            // btnInsert2
            // 
            this.btnInsert2.Location = new System.Drawing.Point(93, 162);
            this.btnInsert2.Name = "btnInsert2";
            this.btnInsert2.Size = new System.Drawing.Size(75, 23);
            this.btnInsert2.TabIndex = 8;
            this.btnInsert2.Text = "INSERT2";
            this.btnInsert2.UseVisualStyleBackColor = true;
            this.btnInsert2.Click += new System.EventHandler(this.btnInsert2_Click);
            // 
            // checkFemale
            // 
            this.checkFemale.AutoSize = true;
            this.checkFemale.Location = new System.Drawing.Point(251, 163);
            this.checkFemale.Name = "checkFemale";
            this.checkFemale.Size = new System.Drawing.Size(48, 16);
            this.checkFemale.TabIndex = 9;
            this.checkFemale.Text = "여자";
            this.checkFemale.UseVisualStyleBackColor = true;
            // 
            // btnIncAllAge
            // 
            this.btnIncAllAge.Location = new System.Drawing.Point(399, 12);
            this.btnIncAllAge.Name = "btnIncAllAge";
            this.btnIncAllAge.Size = new System.Drawing.Size(92, 23);
            this.btnIncAllAge.TabIndex = 10;
            this.btnIncAllAge.Text = "IncAllAge";
            this.btnIncAllAge.UseVisualStyleBackColor = true;
            this.btnIncAllAge.Click += new System.EventHandler(this.btnIncAllAge_Click);
            // 
            // btnIncSomeAge
            // 
            this.btnIncSomeAge.Location = new System.Drawing.Point(399, 41);
            this.btnIncSomeAge.Name = "btnIncSomeAge";
            this.btnIncSomeAge.Size = new System.Drawing.Size(93, 23);
            this.btnIncSomeAge.TabIndex = 11;
            this.btnIncSomeAge.Text = "IncSomeAge";
            this.btnIncSomeAge.UseVisualStyleBackColor = true;
            this.btnIncSomeAge.Click += new System.EventHandler(this.btnIncSomeAge_Click);
            // 
            // btnRollBack
            // 
            this.btnRollBack.Location = new System.Drawing.Point(399, 70);
            this.btnRollBack.Name = "btnRollBack";
            this.btnRollBack.Size = new System.Drawing.Size(93, 23);
            this.btnRollBack.TabIndex = 12;
            this.btnRollBack.Text = "RollBack";
            this.btnRollBack.UseVisualStyleBackColor = true;
            this.btnRollBack.Click += new System.EventHandler(this.btnRollBack_Click);
            // 
            // btnCommit
            // 
            this.btnCommit.Location = new System.Drawing.Point(399, 99);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(93, 23);
            this.btnCommit.TabIndex = 13;
            this.btnCommit.Text = "Commit";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 194);
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.btnRollBack);
            this.Controls.Add(this.btnIncSomeAge);
            this.Controls.Add(this.btnIncAllAge);
            this.Controls.Add(this.checkFemale);
            this.Controls.Add(this.btnInsert2);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInsert1);
            this.Controls.Add(this.checkMale);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.CheckBox checkMale;
        private System.Windows.Forms.Button btnInsert1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.Button btnInsert2;
        private System.Windows.Forms.CheckBox checkFemale;
        private System.Windows.Forms.Button btnIncAllAge;
        private System.Windows.Forms.Button btnIncSomeAge;
        private System.Windows.Forms.Button btnRollBack;
        private System.Windows.Forms.Button btnCommit;
    }
}

