
namespace TreeTest
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
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ultraGrid1 = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_mnu_id = new Infragistics.Win.Misc.UltraLabel();
            this.lbl_mnu_type = new Infragistics.Win.Misc.UltraLabel();
            this.lbl_mnu_nm = new Infragistics.Win.Misc.UltraLabel();
            this.lbl_mnu_seq = new Infragistics.Win.Misc.UltraLabel();
            this.txt_mnu_id = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txt_mnu_type = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txt_mnu_nm = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txt_mnu_seq = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraTree1 = new Infragistics.Win.UltraWinTree.UltraTree();
            this.ultraTextEditor1 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid1)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mnu_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mnu_type)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mnu_nm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mnu_seq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTree1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ultraTextEditor1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.888889F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.5466F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.4534F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ultraTree1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 33);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 414);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.ultraGrid1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(317, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.66247F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.33753F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(474, 408);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // ultraGrid1
            // 
            appearance1.BackColor = System.Drawing.SystemColors.Window;
            appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.ultraGrid1.DisplayLayout.Appearance = appearance1;
            this.ultraGrid1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ultraGrid1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance2.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraGrid1.DisplayLayout.GroupByBox.Appearance = appearance2;
            appearance3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraGrid1.DisplayLayout.GroupByBox.BandLabelAppearance = appearance3;
            this.ultraGrid1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance4.BackColor2 = System.Drawing.SystemColors.Control;
            appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraGrid1.DisplayLayout.GroupByBox.PromptAppearance = appearance4;
            this.ultraGrid1.DisplayLayout.MaxColScrollRegions = 1;
            this.ultraGrid1.DisplayLayout.MaxRowScrollRegions = 1;
            appearance5.BackColor = System.Drawing.SystemColors.Window;
            appearance5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ultraGrid1.DisplayLayout.Override.ActiveCellAppearance = appearance5;
            appearance6.BackColor = System.Drawing.SystemColors.Highlight;
            appearance6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ultraGrid1.DisplayLayout.Override.ActiveRowAppearance = appearance6;
            this.ultraGrid1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.ultraGrid1.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance7.BackColor = System.Drawing.SystemColors.Window;
            this.ultraGrid1.DisplayLayout.Override.CardAreaAppearance = appearance7;
            appearance8.BorderColor = System.Drawing.Color.Silver;
            appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.ultraGrid1.DisplayLayout.Override.CellAppearance = appearance8;
            this.ultraGrid1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.ultraGrid1.DisplayLayout.Override.CellPadding = 0;
            appearance9.BackColor = System.Drawing.SystemColors.Control;
            appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance9.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraGrid1.DisplayLayout.Override.GroupByRowAppearance = appearance9;
            appearance10.TextHAlignAsString = "Left";
            this.ultraGrid1.DisplayLayout.Override.HeaderAppearance = appearance10;
            this.ultraGrid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.ultraGrid1.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance11.BackColor = System.Drawing.SystemColors.Window;
            appearance11.BorderColor = System.Drawing.Color.Silver;
            this.ultraGrid1.DisplayLayout.Override.RowAppearance = appearance11;
            this.ultraGrid1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ultraGrid1.DisplayLayout.Override.TemplateAddRowAppearance = appearance12;
            this.ultraGrid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ultraGrid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ultraGrid1.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraGrid1.Location = new System.Drawing.Point(3, 91);
            this.ultraGrid1.Name = "ultraGrid1";
            this.ultraGrid1.Size = new System.Drawing.Size(468, 314);
            this.ultraGrid1.TabIndex = 0;
            this.ultraGrid1.Text = "ultraGrid1";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 9;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel4.Controls.Add(this.lbl_mnu_id, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.lbl_mnu_type, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.lbl_mnu_nm, 5, 1);
            this.tableLayoutPanel4.Controls.Add(this.lbl_mnu_seq, 5, 2);
            this.tableLayoutPanel4.Controls.Add(this.txt_mnu_id, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.txt_mnu_type, 3, 2);
            this.tableLayoutPanel4.Controls.Add(this.txt_mnu_nm, 7, 1);
            this.tableLayoutPanel4.Controls.Add(this.txt_mnu_seq, 7, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(468, 82);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // lbl_mnu_id
            // 
            this.lbl_mnu_id.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_mnu_id.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_mnu_id.Location = new System.Drawing.Point(8, 13);
            this.lbl_mnu_id.Name = "lbl_mnu_id";
            this.lbl_mnu_id.Size = new System.Drawing.Size(101, 25);
            this.lbl_mnu_id.TabIndex = 0;
            this.lbl_mnu_id.Text = "MNU_ID : ";
            // 
            // lbl_mnu_type
            // 
            this.lbl_mnu_type.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_mnu_type.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_mnu_type.Location = new System.Drawing.Point(8, 44);
            this.lbl_mnu_type.Name = "lbl_mnu_type";
            this.lbl_mnu_type.Size = new System.Drawing.Size(101, 25);
            this.lbl_mnu_type.TabIndex = 1;
            this.lbl_mnu_type.Text = "MNU_TYPE : ";
            // 
            // lbl_mnu_nm
            // 
            this.lbl_mnu_nm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_mnu_nm.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_mnu_nm.Location = new System.Drawing.Point(242, 13);
            this.lbl_mnu_nm.Name = "lbl_mnu_nm";
            this.lbl_mnu_nm.Size = new System.Drawing.Size(101, 25);
            this.lbl_mnu_nm.TabIndex = 2;
            this.lbl_mnu_nm.Text = "MNU_NM : ";
            // 
            // lbl_mnu_seq
            // 
            this.lbl_mnu_seq.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_mnu_seq.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_mnu_seq.Location = new System.Drawing.Point(242, 44);
            this.lbl_mnu_seq.Name = "lbl_mnu_seq";
            this.lbl_mnu_seq.Size = new System.Drawing.Size(101, 25);
            this.lbl_mnu_seq.TabIndex = 3;
            this.lbl_mnu_seq.Text = "MNU_SEQ : ";
            // 
            // txt_mnu_id
            // 
            this.txt_mnu_id.AutoSize = false;
            this.txt_mnu_id.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_mnu_id.Location = new System.Drawing.Point(125, 13);
            this.txt_mnu_id.Name = "txt_mnu_id";
            this.txt_mnu_id.ReadOnly = true;
            this.txt_mnu_id.Size = new System.Drawing.Size(101, 25);
            this.txt_mnu_id.TabIndex = 4;
            // 
            // txt_mnu_type
            // 
            this.txt_mnu_type.AutoSize = false;
            this.txt_mnu_type.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_mnu_type.Location = new System.Drawing.Point(125, 44);
            this.txt_mnu_type.Name = "txt_mnu_type";
            this.txt_mnu_type.ReadOnly = true;
            this.txt_mnu_type.Size = new System.Drawing.Size(101, 25);
            this.txt_mnu_type.TabIndex = 5;
            // 
            // txt_mnu_nm
            // 
            this.txt_mnu_nm.AutoSize = false;
            this.txt_mnu_nm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_mnu_nm.Location = new System.Drawing.Point(359, 13);
            this.txt_mnu_nm.Name = "txt_mnu_nm";
            this.txt_mnu_nm.ReadOnly = true;
            this.txt_mnu_nm.Size = new System.Drawing.Size(101, 25);
            this.txt_mnu_nm.TabIndex = 6;
            // 
            // txt_mnu_seq
            // 
            this.txt_mnu_seq.AutoSize = false;
            this.txt_mnu_seq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_mnu_seq.Location = new System.Drawing.Point(359, 44);
            this.txt_mnu_seq.Name = "txt_mnu_seq";
            this.txt_mnu_seq.ReadOnly = true;
            this.txt_mnu_seq.Size = new System.Drawing.Size(101, 25);
            this.txt_mnu_seq.TabIndex = 7;
            // 
            // ultraTree1
            // 
            this.ultraTree1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraTree1.Location = new System.Drawing.Point(3, 3);
            this.ultraTree1.Name = "ultraTree1";
            this.ultraTree1.Size = new System.Drawing.Size(308, 408);
            this.ultraTree1.TabIndex = 2;
            this.ultraTree1.AfterSelect += new Infragistics.Win.UltraWinTree.AfterNodeSelectEventHandler(this.ultraTree1_AfterSelect);
            // 
            // ultraTextEditor1
            // 
            this.ultraTextEditor1.AutoSize = false;
            this.ultraTextEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraTextEditor1.Enabled = false;
            this.ultraTextEditor1.Location = new System.Drawing.Point(3, 3);
            this.ultraTextEditor1.Name = "ultraTextEditor1";
            this.ultraTextEditor1.Size = new System.Drawing.Size(794, 24);
            this.ultraTextEditor1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid1)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_mnu_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mnu_type)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mnu_nm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mnu_seq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTree1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Infragistics.Win.UltraWinTree.UltraTree ultraTree1;
        private Infragistics.Win.UltraWinGrid.UltraGrid ultraGrid1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Infragistics.Win.Misc.UltraLabel lbl_mnu_id;
        private Infragistics.Win.Misc.UltraLabel lbl_mnu_type;
        private Infragistics.Win.Misc.UltraLabel lbl_mnu_nm;
        private Infragistics.Win.Misc.UltraLabel lbl_mnu_seq;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txt_mnu_id;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txt_mnu_type;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txt_mnu_nm;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txt_mnu_seq;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditor1;
    }
}

