
namespace CUDTestProgram
{
    partial class Login
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLogin = new Infragistics.Win.Misc.UltraButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnReset = new Infragistics.Win.Misc.UltraButton();
            this.lblPW = new Infragistics.Win.Misc.UltraLabel();
            this.lblID = new Infragistics.Win.Misc.UltraLabel();
            this.lblTable = new Infragistics.Win.Misc.UltraLabel();
            this.lblDBnm = new Infragistics.Win.Misc.UltraLabel();
            this.lblIP = new Infragistics.Win.Misc.UltraLabel();
            this.txtIP = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtDBnm = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtTable = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtID = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtPW = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDBnm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPW)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 11);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.lblPW, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.lblID, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblTable, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblDBnm, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblIP, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtIP, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDBnm, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtTable, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtID, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtPW, 2, 9);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 13;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(369, 251);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnLogin, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(131, 210);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(225, 30);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogin.Location = new System.Drawing.Point(112, 0);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(113, 30);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "로그인";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.btnReset, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(10, 210);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(121, 30);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // btnReset
            // 
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReset.Location = new System.Drawing.Point(0, 0);
            this.btnReset.Margin = new System.Windows.Forms.Padding(0);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(121, 30);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "초기화";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblPW
            // 
            this.lblPW.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPW.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPW.Location = new System.Drawing.Point(10, 170);
            this.lblPW.Margin = new System.Windows.Forms.Padding(0);
            this.lblPW.Name = "lblPW";
            this.lblPW.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPW.Size = new System.Drawing.Size(121, 30);
            this.lblPW.TabIndex = 2;
            this.lblPW.Text = " : 비밀번호";
            // 
            // lblID
            // 
            this.lblID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblID.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblID.Location = new System.Drawing.Point(10, 130);
            this.lblID.Margin = new System.Windows.Forms.Padding(0);
            this.lblID.Name = "lblID";
            this.lblID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblID.Size = new System.Drawing.Size(121, 30);
            this.lblID.TabIndex = 3;
            this.lblID.Text = " : ID";
            // 
            // lblTable
            // 
            this.lblTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTable.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTable.Location = new System.Drawing.Point(10, 90);
            this.lblTable.Margin = new System.Windows.Forms.Padding(0);
            this.lblTable.Name = "lblTable";
            this.lblTable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTable.Size = new System.Drawing.Size(121, 30);
            this.lblTable.TabIndex = 4;
            this.lblTable.Text = " : 테이블";
            // 
            // lblDBnm
            // 
            this.lblDBnm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDBnm.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDBnm.Location = new System.Drawing.Point(10, 50);
            this.lblDBnm.Margin = new System.Windows.Forms.Padding(0);
            this.lblDBnm.Name = "lblDBnm";
            this.lblDBnm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDBnm.Size = new System.Drawing.Size(121, 30);
            this.lblDBnm.TabIndex = 5;
            this.lblDBnm.Text = " : DB 이름 ";
            // 
            // lblIP
            // 
            this.lblIP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIP.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblIP.Location = new System.Drawing.Point(10, 10);
            this.lblIP.Margin = new System.Windows.Forms.Padding(0);
            this.lblIP.Name = "lblIP";
            this.lblIP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblIP.Size = new System.Drawing.Size(121, 30);
            this.lblIP.TabIndex = 6;
            this.lblIP.Text = " : 서버 주소";
            // 
            // txtIP
            // 
            this.txtIP.AutoSize = false;
            this.txtIP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtIP.Location = new System.Drawing.Point(131, 10);
            this.txtIP.Margin = new System.Windows.Forms.Padding(0);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(225, 30);
            this.txtIP.TabIndex = 7;
            // 
            // txtDBnm
            // 
            this.txtDBnm.AutoSize = false;
            this.txtDBnm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDBnm.Location = new System.Drawing.Point(131, 50);
            this.txtDBnm.Margin = new System.Windows.Forms.Padding(0);
            this.txtDBnm.Name = "txtDBnm";
            this.txtDBnm.Size = new System.Drawing.Size(225, 30);
            this.txtDBnm.TabIndex = 8;
            // 
            // txtTable
            // 
            this.txtTable.AutoSize = false;
            this.txtTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTable.Location = new System.Drawing.Point(131, 90);
            this.txtTable.Margin = new System.Windows.Forms.Padding(0);
            this.txtTable.Name = "txtTable";
            this.txtTable.Size = new System.Drawing.Size(225, 30);
            this.txtTable.TabIndex = 9;
            // 
            // txtID
            // 
            this.txtID.AutoSize = false;
            this.txtID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtID.Location = new System.Drawing.Point(131, 130);
            this.txtID.Margin = new System.Windows.Forms.Padding(0);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(225, 30);
            this.txtID.TabIndex = 10;
            // 
            // txtPW
            // 
            this.txtPW.AutoSize = false;
            this.txtPW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPW.Location = new System.Drawing.Point(131, 170);
            this.txtPW.Margin = new System.Windows.Forms.Padding(0);
            this.txtPW.Name = "txtPW";
            this.txtPW.PasswordChar = '*';
            this.txtPW.Size = new System.Drawing.Size(225, 30);
            this.txtPW.TabIndex = 11;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 251);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Login";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtIP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDBnm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPW)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Infragistics.Win.Misc.UltraButton btnReset;
        private Infragistics.Win.Misc.UltraButton btnLogin;
        private Infragistics.Win.Misc.UltraLabel lblPW;
        private Infragistics.Win.Misc.UltraLabel lblID;
        private Infragistics.Win.Misc.UltraLabel lblTable;
        private Infragistics.Win.Misc.UltraLabel lblDBnm;
        private Infragistics.Win.Misc.UltraLabel lblIP;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtIP;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtDBnm;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtTable;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtID;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtPW;
    }
}

