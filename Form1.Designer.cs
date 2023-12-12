namespace Hasan.badr_harjoitus4
{
    partial class IkäForm
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
            SyntymaAikaDT = new DateTimePicker();
            VuosinaLB = new Label();
            KuukausinaLB = new Label();
            päivinäLB = new Label();
            TunteinaLB = new Label();
            MinuutteinaLB = new Label();
            SekunteinaLB = new Label();
            LakeIkaBT = new Button();
            SuspendLayout();
            // 
            // SyntymaAikaDT
            // 
            SyntymaAikaDT.Location = new Point(12, 12);
            SyntymaAikaDT.Name = "SyntymaAikaDT";
            SyntymaAikaDT.Size = new Size(341, 35);
            SyntymaAikaDT.TabIndex = 0;
            // 
            // VuosinaLB
            // 
            VuosinaLB.AutoSize = true;
            VuosinaLB.Location = new Point(12, 73);
            VuosinaLB.Name = "VuosinaLB";
            VuosinaLB.Size = new Size(84, 30);
            VuosinaLB.TabIndex = 1;
            VuosinaLB.Text = "vuosina";
            VuosinaLB.Visible = false;
            // 
            // KuukausinaLB
            // 
            KuukausinaLB.AutoSize = true;
            KuukausinaLB.Location = new Point(12, 129);
            KuukausinaLB.Name = "KuukausinaLB";
            KuukausinaLB.Size = new Size(119, 30);
            KuukausinaLB.TabIndex = 2;
            KuukausinaLB.Text = "Kuukausina";
            KuukausinaLB.Visible = false;
            // 
            // päivinäLB
            // 
            päivinäLB.AutoSize = true;
            päivinäLB.Location = new Point(12, 180);
            päivinäLB.Name = "päivinäLB";
            päivinäLB.Size = new Size(78, 30);
            päivinäLB.TabIndex = 3;
            päivinäLB.Text = "Päivinä";
            päivinäLB.Visible = false;
            // 
            // TunteinaLB
            // 
            TunteinaLB.AutoSize = true;
            TunteinaLB.Location = new Point(259, 73);
            TunteinaLB.Name = "TunteinaLB";
            TunteinaLB.Size = new Size(94, 30);
            TunteinaLB.TabIndex = 4;
            TunteinaLB.Text = "Tunteina";
            TunteinaLB.Visible = false;
            // 
            // MinuutteinaLB
            // 
            MinuutteinaLB.AutoSize = true;
            MinuutteinaLB.Location = new Point(259, 129);
            MinuutteinaLB.Name = "MinuutteinaLB";
            MinuutteinaLB.Size = new Size(126, 30);
            MinuutteinaLB.TabIndex = 5;
            MinuutteinaLB.Text = "Minuutteina";
            MinuutteinaLB.Visible = false;
            // 
            // SekunteinaLB
            // 
            SekunteinaLB.AutoSize = true;
            SekunteinaLB.Location = new Point(259, 180);
            SekunteinaLB.Name = "SekunteinaLB";
            SekunteinaLB.Size = new Size(115, 30);
            SekunteinaLB.TabIndex = 6;
            SekunteinaLB.Text = "Sekunteina";
            SekunteinaLB.Visible = false;
            // 
            // LakeIkaBT
            // 
            LakeIkaBT.Location = new Point(411, 12);
            LakeIkaBT.Name = "LakeIkaBT";
            LakeIkaBT.Size = new Size(114, 35);
            LakeIkaBT.TabIndex = 7;
            LakeIkaBT.Text = "Laske ";
            LakeIkaBT.UseVisualStyleBackColor = true;
            LakeIkaBT.Click += LakelkaBT_Click;
            // 
            // IkäForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 252);
            Controls.Add(LakeIkaBT);
            Controls.Add(SekunteinaLB);
            Controls.Add(MinuutteinaLB);
            Controls.Add(TunteinaLB);
            Controls.Add(päivinäLB);
            Controls.Add(KuukausinaLB);
            Controls.Add(VuosinaLB);
            Controls.Add(SyntymaAikaDT);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "IkäForm";
            Text = "Ikälaskuri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker SyntymaAikaDT;
        private Label VuosinaLB;
        private Label KuukausinaLB;
        private Label päivinäLB;
        private Label TunteinaLB;
        private Label MinuutteinaLB;
        private Label SekunteinaLB;
        private Button LakeIkaBT;
    }
}