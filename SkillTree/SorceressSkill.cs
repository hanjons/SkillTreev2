using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkillTree
{
	
	public partial class SorceressSkill : UserControl
	{
		public event Update OnUpdate;

		public SorceressSkill()
		{
			InitializeComponent();
		}

		private void SorceressSkill_Load(object sender, EventArgs e)
		{
			FireVolt.OnUpdate += new Update(UpdateHandler);
			Wram.OnUpdate += new Update(UpdateHandler);
			Inferno.OnUpdate += new Update(UpdateHandler);
			Blaze.OnUpdate += new Update(UpdateHandler);
			FireBall.OnUpdate += new Update(UpdateHandler);
			FireWall.OnUpdate += new Update(UpdateHandler);
			Inchent.OnUpdate += new Update(UpdateHandler);
			Meteo.OnUpdate += new Update(UpdateHandler);
			FireMastary.OnUpdate += new Update(UpdateHandler);
			Hydra.OnUpdate += new Update(UpdateHandler);
		}
		private void UpdateHandler(object sender, EventArgs e, string a_SkillName)
		{
			if (OnUpdate != null)
			{
				OnUpdate(sender, e, a_SkillName);
			}
		}

		private void SorceressSkill_VisibleChanged(object sender, EventArgs e)
		{
			FireVolt.SetSkillPoints = "0";
			Wram.SetSkillPoints = "0";
			Inferno.SetSkillPoints = "0";
			Blaze.SetSkillPoints = "0";
			FireBall.SetSkillPoints = "0";
			FireWall.SetSkillPoints = "0";
			Inchent.SetSkillPoints = "0";
			Meteo.SetSkillPoints = "0";
			FireMastary.SetSkillPoints = "0";
			Hydra.SetSkillPoints = "0";

			FireVolt.setTextBoxColor();
			Wram.setTextBoxColor();
			Inferno.setTextBoxColor();
			Blaze.setTextBoxColor();
			FireBall.setTextBoxColor();
			FireWall.setTextBoxColor();
			Inchent.setTextBoxColor();
			Meteo.setTextBoxColor();
			FireMastary.setTextBoxColor();
			Hydra.setTextBoxColor();
		}
	}
}
