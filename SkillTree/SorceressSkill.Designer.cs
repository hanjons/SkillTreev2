namespace SkillTree
{
	partial class SorceressSkill
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
			this.FireVolt = new SkillTree.SkillObject();
			this.Wram = new SkillTree.SkillObject();
			this.Inferno = new SkillTree.SkillObject();
			this.Blaze = new SkillTree.SkillObject();
			this.FireBall = new SkillTree.SkillObject();
			this.Inchent = new SkillTree.SkillObject();
			this.FireWall = new SkillTree.SkillObject();
			this.Meteo = new SkillTree.SkillObject();
			this.Hydra = new SkillTree.SkillObject();
			this.FireMastary = new SkillTree.SkillObject();
			this.SuspendLayout();
			// 
			// FireVolt
			// 
			this.FireVolt.Location = new System.Drawing.Point(179, 43);
			this.FireVolt.Name = "FireVolt";
			this.FireVolt.SetSkillPoints = "0";
			this.FireVolt.Size = new System.Drawing.Size(72, 61);
			this.FireVolt.SkillBackImage = global::SkillTree.Properties.Resources.SorceressFireArrow;
			this.FireVolt.TabIndex = 0;
			// 
			// Wram
			// 
			this.Wram.Location = new System.Drawing.Point(293, 43);
			this.Wram.Name = "Wram";
			this.Wram.SetSkillPoints = "0";
			this.Wram.Size = new System.Drawing.Size(72, 61);
			this.Wram.SkillBackImage = global::SkillTree.Properties.Resources.SorceressWruth;
			this.Wram.TabIndex = 1;
			// 
			// Inferno
			// 
			this.Inferno.Location = new System.Drawing.Point(44, 105);
			this.Inferno.Name = "Inferno";
			this.Inferno.SetSkillPoints = "0";
			this.Inferno.Size = new System.Drawing.Size(72, 61);
			this.Inferno.SkillBackImage = global::SkillTree.Properties.Resources.SorceressInferno;
			this.Inferno.TabIndex = 2;
			// 
			// Blaze
			// 
			this.Blaze.Location = new System.Drawing.Point(44, 178);
			this.Blaze.Name = "Blaze";
			this.Blaze.SetSkillPoints = "0";
			this.Blaze.Size = new System.Drawing.Size(72, 61);
			this.Blaze.SkillBackImage = global::SkillTree.Properties.Resources.SorceressBlaze;
			this.Blaze.TabIndex = 3;
			// 
			// FireBall
			// 
			this.FireBall.Location = new System.Drawing.Point(167, 178);
			this.FireBall.Name = "FireBall";
			this.FireBall.SetSkillPoints = "0";
			this.FireBall.Size = new System.Drawing.Size(72, 61);
			this.FireBall.SkillBackImage = global::SkillTree.Properties.Resources.SorceressFireBall;
			this.FireBall.TabIndex = 4;
			// 
			// Inchent
			// 
			this.Inchent.Location = new System.Drawing.Point(304, 208);
			this.Inchent.Name = "Inchent";
			this.Inchent.SetSkillPoints = "0";
			this.Inchent.Size = new System.Drawing.Size(72, 61);
			this.Inchent.SkillBackImage = global::SkillTree.Properties.Resources.SorceressEnchant;
			this.Inchent.TabIndex = 5;
			// 
			// FireWall
			// 
			this.FireWall.Location = new System.Drawing.Point(44, 325);
			this.FireWall.Name = "FireWall";
			this.FireWall.SetSkillPoints = "0";
			this.FireWall.Size = new System.Drawing.Size(72, 61);
			this.FireWall.SkillBackImage = global::SkillTree.Properties.Resources.SorceressFireWall;
			this.FireWall.TabIndex = 6;
			// 
			// Meteo
			// 
			this.Meteo.Location = new System.Drawing.Point(167, 294);
			this.Meteo.Name = "Meteo";
			this.Meteo.SetSkillPoints = "0";
			this.Meteo.Size = new System.Drawing.Size(72, 61);
			this.Meteo.SkillBackImage = global::SkillTree.Properties.Resources.SorceressMeteo;
			this.Meteo.TabIndex = 7;
			// 
			// Hydra
			// 
			this.Hydra.Location = new System.Drawing.Point(304, 382);
			this.Hydra.Name = "Hydra";
			this.Hydra.SetSkillPoints = "0";
			this.Hydra.Size = new System.Drawing.Size(72, 61);
			this.Hydra.SkillBackImage = global::SkillTree.Properties.Resources.SorceressHydra;
			this.Hydra.TabIndex = 8;
			// 
			// FireMastary
			// 
			this.FireMastary.Location = new System.Drawing.Point(167, 382);
			this.FireMastary.Name = "FireMastary";
			this.FireMastary.SetSkillPoints = "0";
			this.FireMastary.Size = new System.Drawing.Size(72, 61);
			this.FireMastary.SkillBackImage = global::SkillTree.Properties.Resources.SorceressFireMastery;
			this.FireMastary.TabIndex = 9;
			// 
			// SorceressSkill
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.FireMastary);
			this.Controls.Add(this.Hydra);
			this.Controls.Add(this.Meteo);
			this.Controls.Add(this.FireWall);
			this.Controls.Add(this.Inchent);
			this.Controls.Add(this.FireBall);
			this.Controls.Add(this.Blaze);
			this.Controls.Add(this.Inferno);
			this.Controls.Add(this.Wram);
			this.Controls.Add(this.FireVolt);
			this.Name = "SorceressSkill";
			this.Size = new System.Drawing.Size(440, 492);
			this.Load += new System.EventHandler(this.SorceressSkill_Load);
			this.VisibleChanged += new System.EventHandler(this.SorceressSkill_VisibleChanged);
			this.ResumeLayout(false);

		}

		#endregion

		private SkillObject FireVolt;
		private SkillObject Wram;
		private SkillObject Inferno;
		private SkillObject Blaze;
		private SkillObject FireBall;
		private SkillObject Inchent;
		private SkillObject FireWall;
		private SkillObject Meteo;
		private SkillObject Hydra;
		private SkillObject FireMastary;
	}
}
