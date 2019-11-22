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
	public partial class BabarianSkill : UserControl
	{
        public event Update OnUpdate;

        public BabarianSkill()
		{
			InitializeComponent();
		}
		private void BabarianSkill_Load(object sender, EventArgs e)
		{
			Bash.OnUpdate += new Update(UpdateHandler);
			Leap.OnUpdate += new Update(UpdateHandler);
			DoubleSwing.OnUpdate += new Update(UpdateHandler);
			Stun.OnUpdate += new Update(UpdateHandler);
			DoubleThrow.OnUpdate += new Update(UpdateHandler);
			LeapAtk.OnUpdate += new Update(UpdateHandler);
			ConRate.OnUpdate += new Update(UpdateHandler);
			Frengy.OnUpdate += new Update(UpdateHandler);
			WhellWind.OnUpdate += new Update(UpdateHandler);
			Berserk.OnUpdate += new Update(UpdateHandler);
		}
	
		private void UpdateHandler(object sender, EventArgs e, string a_SkillName)
		{
			if (OnUpdate != null)
			{
				OnUpdate(sender, e, a_SkillName);
			}
		}

		private void BabarianSkill_VisibleChanged(object sender, EventArgs e)
		{
			Bash.SetSkillPoints = "0";
			Leap.SetSkillPoints = "0";
			DoubleSwing.SetSkillPoints = "0";
			Stun.SetSkillPoints = "0";
			DoubleThrow.SetSkillPoints = "0";
			LeapAtk.SetSkillPoints = "0";
			ConRate.SetSkillPoints = "0";
			Frengy.SetSkillPoints = "0";
			WhellWind.SetSkillPoints = "0";
			Berserk.SetSkillPoints = "0";

			Bash.setTextBoxColor();
			Leap.setTextBoxColor();
			DoubleSwing.setTextBoxColor();
			Stun.setTextBoxColor();
			DoubleThrow.setTextBoxColor();
			LeapAtk.setTextBoxColor();
			ConRate.setTextBoxColor();
			Frengy.setTextBoxColor();
			WhellWind.setTextBoxColor();
			Berserk.setTextBoxColor();
		}

		
	}
}
