namespace SkillTree
{
	partial class BabarianSkill
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

		#region 구성 요소 디자이너에서 생성한 코드

		/// <summary> 
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.Bash = new SkillTree.SkillObject();
			this.Leap = new SkillTree.SkillObject();
			this.DoubleSwing = new SkillTree.SkillObject();
			this.Stun = new SkillTree.SkillObject();
			this.DoubleThrow = new SkillTree.SkillObject();
			this.LeapAtk = new SkillTree.SkillObject();
			this.ConRate = new SkillTree.SkillObject();
			this.Frengy = new SkillTree.SkillObject();
			this.Berserk = new SkillTree.SkillObject();
			this.WhellWind = new SkillTree.SkillObject();
			this.SuspendLayout();
			// 
			// Bash
			// 
			this.Bash.Location = new System.Drawing.Point(168, 20);
			this.Bash.Name = "Bash";
			this.Bash.SetSkillPoints = "0";
			this.Bash.Size = new System.Drawing.Size(72, 61);
			this.Bash.SkillBackImage = global::SkillTree.Properties.Resources.BabarianBash;
			this.Bash.TabIndex = 0;
			// 
			// Leap
			// 
			this.Leap.Location = new System.Drawing.Point(43, 101);
			this.Leap.Name = "Leap";
			this.Leap.SetSkillPoints = "0";
			this.Leap.Size = new System.Drawing.Size(72, 61);
			this.Leap.SkillBackImage = global::SkillTree.Properties.Resources.BabarianLeap;
			this.Leap.TabIndex = 1;
			// 
			// DoubleSwing
			// 
			this.DoubleSwing.Location = new System.Drawing.Point(313, 101);
			this.DoubleSwing.Name = "DoubleSwing";
			this.DoubleSwing.SetSkillPoints = "0";
			this.DoubleSwing.Size = new System.Drawing.Size(72, 61);
			this.DoubleSwing.SkillBackImage = global::SkillTree.Properties.Resources.BabarianDoubleSwing;
			this.DoubleSwing.TabIndex = 2;
			// 
			// Stun
			// 
			this.Stun.Location = new System.Drawing.Point(168, 176);
			this.Stun.Name = "Stun";
			this.Stun.SetSkillPoints = "0";
			this.Stun.Size = new System.Drawing.Size(72, 61);
			this.Stun.SkillBackImage = global::SkillTree.Properties.Resources.BabarianStun;
			this.Stun.TabIndex = 3;
			// 
			// DoubleThrow
			// 
			this.DoubleThrow.Location = new System.Drawing.Point(313, 176);
			this.DoubleThrow.Name = "DoubleThrow";
			this.DoubleThrow.SetSkillPoints = "0";
			this.DoubleThrow.Size = new System.Drawing.Size(72, 61);
			this.DoubleThrow.SkillBackImage = global::SkillTree.Properties.Resources.BabarianDoubleThrow;
			this.DoubleThrow.TabIndex = 4;
			// 
			// LeapAtk
			// 
			this.LeapAtk.Location = new System.Drawing.Point(43, 265);
			this.LeapAtk.Name = "LeapAtk";
			this.LeapAtk.SetSkillPoints = "0";
			this.LeapAtk.Size = new System.Drawing.Size(72, 61);
			this.LeapAtk.SkillBackImage = global::SkillTree.Properties.Resources.BabarianLeapAtk;
			this.LeapAtk.TabIndex = 5;
			// 
			// ConRate
			// 
			this.ConRate.Location = new System.Drawing.Point(168, 265);
			this.ConRate.Name = "ConRate";
			this.ConRate.SetSkillPoints = "0";
			this.ConRate.Size = new System.Drawing.Size(72, 61);
			this.ConRate.SkillBackImage = global::SkillTree.Properties.Resources.BabarianCon;
			this.ConRate.TabIndex = 6;
			// 
			// Frengy
			// 
			this.Frengy.Location = new System.Drawing.Point(313, 339);
			this.Frengy.Name = "Frengy";
			this.Frengy.SetSkillPoints = "0";
			this.Frengy.Size = new System.Drawing.Size(72, 61);
			this.Frengy.SkillBackImage = global::SkillTree.Properties.Resources.BabarianFrengy;
			this.Frengy.TabIndex = 7;
			// 
			// Berserk
			// 
			this.Berserk.Location = new System.Drawing.Point(168, 395);
			this.Berserk.Name = "Berserk";
			this.Berserk.SetSkillPoints = "0";
			this.Berserk.Size = new System.Drawing.Size(72, 61);
			this.Berserk.SkillBackImage = global::SkillTree.Properties.Resources.BabarianBur;
			this.Berserk.TabIndex = 8;
			// 
			// WhellWind
			// 
			this.WhellWind.Location = new System.Drawing.Point(43, 395);
			this.WhellWind.Name = "WhellWind";
			this.WhellWind.SetSkillPoints = "0";
			this.WhellWind.Size = new System.Drawing.Size(72, 61);
			this.WhellWind.SkillBackImage = global::SkillTree.Properties.Resources.BabarianWhirlind;
			this.WhellWind.TabIndex = 9;
			// 
			// BabarianSkill
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.WhellWind);
			this.Controls.Add(this.Berserk);
			this.Controls.Add(this.Frengy);
			this.Controls.Add(this.ConRate);
			this.Controls.Add(this.LeapAtk);
			this.Controls.Add(this.DoubleThrow);
			this.Controls.Add(this.Stun);
			this.Controls.Add(this.DoubleSwing);
			this.Controls.Add(this.Leap);
			this.Controls.Add(this.Bash);
			this.Name = "BabarianSkill";
			this.Size = new System.Drawing.Size(440, 492);
			this.Load += new System.EventHandler(this.BabarianSkill_Load);
			this.VisibleChanged += new System.EventHandler(this.BabarianSkill_VisibleChanged);
			this.ResumeLayout(false);

		}

		#endregion

		private SkillObject Bash;
		private SkillObject Leap;
		private SkillObject DoubleSwing;
		private SkillObject Stun;
		private SkillObject DoubleThrow;
		private SkillObject LeapAtk;
		private SkillObject ConRate;
		private SkillObject Frengy;
		private SkillObject WhellWind;
		private SkillObject Berserk;
	}
}
