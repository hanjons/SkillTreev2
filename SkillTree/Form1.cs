using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

enum JobClass
{
	Amazon,
	Babarian,
	Sorceress,
}

public struct Skill
{
	public string skillName;
	public int skillNumber;
	public string skillNotification;
	public int skillLevel;
	public int damege;
	public int manaCost;
	public int parentsSkillNumber;
	public string job;

	public Skill(string skillName, int skillNumber, string skillNotification, int skillLevel, int damege, int manaCost, int parentsSkillNumber, string job)
	{
		this.skillName = skillName;
		this.skillNumber = skillNumber;
		this.skillNotification = skillNotification;
		this.skillLevel = skillLevel;
		this.damege = damege;
		this.manaCost = manaCost;
		this.parentsSkillNumber = parentsSkillNumber;
		this.job = job;
	}
}



public struct status
{
    public int level;
    public int str;
    public int dex;
    public int vitalty;
    public int energy;
    public string jobclass;
    public int statPoint;
    public int skillPoint;
    public int Atk;
    public int AtkRating;
    public int helth;
    public int mana;
}

namespace SkillTree
{
	public delegate void Update(object sender, EventArgs e, string a_SkillName);

	public partial class Form1 : Form
    {
		public static status playerStat;
		public static Skill[] NowSkillClass = null;
		public static Skill[] SkillOfAmazon = new Skill[10];
		public static Skill[] SkillOfBabarian = new Skill[10];
		public static Skill[] SkillOfSorceress = new Skill[10];
		public Form1 frm { get { return this; } }

		public Form1()
        {
            InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
        {
			AmazonSkill1.Visible = false;
			babarianSkill1.Visible = false;
			sorceressSkill1.Visible = false;
			playerStat.level = 1;
			InitSkilltree();
			AmazonSkill1.OnUpdate += new Update(this.UpdateHandler);
            babarianSkill1.OnUpdate += new Update(this.UpdateHandler);
			sorceressSkill1.OnUpdate += new Update(this.UpdateHandler);
		}
	

		private void UpdateHandler(object sender, EventArgs e, string a_SkillName)
		{
            UpdateSkill(a_SkillName);
            statUpdate();
        }

        public void UpdateSkill(string a_SkillName)
		{
            for (int i = 0; i < NowSkillClass.Length; i++)
            {
                if (NowSkillClass[i].skillName == a_SkillName)
                {
                    
                    SkillDamegePoint.Text = (NowSkillClass[i].damege * playerStat.dex).ToString();
                    CostbySkill.Text = (playerStat.mana / NowSkillClass[i].manaCost).ToString();
                   
                }
            }
        }

        public void InitSkilltree()
		{
			SkillOfAmazon[0] = (new Skill("MagicArrow", 1, "마법화살발사", 0, 2, 2, 9,"Amazon"));
			SkillOfAmazon[1] = (new Skill("FireArrow", 2, "화염화살발사", 0, 2, 2, 9, "Amazon"));
			SkillOfAmazon[2] = (new Skill("ColdArrow", 3, "얼음화살발사", 0, 2, 2, 9, "Amazon"));
			SkillOfAmazon[3] = (new Skill("MultyArrow", 4, "다발사격", 0, 4, 3, 0, "Amazon"));
			SkillOfAmazon[4] = (new Skill("ExplodingArrow", 5, "폭발화살발사", 0, 4, 3, 1, "Amazon"));
			SkillOfAmazon[5] = (new Skill("IceArrow", 6, "다중얼음화살발사", 0, 4, 3, 2, "Amazon"));
			SkillOfAmazon[6] = (new Skill("GuideArrow", 7, "유도화살발사", 0, 5, 4, 3, "Amazon"));
			SkillOfAmazon[7] = (new Skill("FireWallArrow", 8, "화염벽화살발사", 0, 10, 4, 4, "Amazon"));
			SkillOfAmazon[8] = (new Skill("SplitArrow", 9, "빠르게여러발사격", 0, 10, 10, 6, "Amazon"));
			SkillOfAmazon[9] = (new Skill("FrozenArrow", 10, "주변의모든것을얼림", 0, 10, 10, 5, "Amazon"));
			// FireArrow → ExplodingArrow → FireWallArrow           // 파이어스킬트리 순서
			// MagicArrow → MultyArrow → GuideArrow → SplitArrow    //물리스킬트리 순서
			// ColdArrow → IceArrow → FrozenArrow                   //아이스 스킬트리 순서

			SkillOfBabarian[0] = (new Skill("Bash", 1, "적을 뒤로 밀치며타격", 0, 2, 2, 9, "Babarian"));
			SkillOfBabarian[1] = (new Skill("Leap", 2, "점프", 0, 2, 2, 9, "Babarian"));
			SkillOfBabarian[2] = (new Skill("DoubleSwing", 3, "두번 타격", 0, 2, 2, 9, "Babarian"));
			SkillOfBabarian[3] = (new Skill("Stun", 4, "적을기절시킴", 0, 4, 3, 0, "Babarian"));
			SkillOfBabarian[4] = (new Skill("DoubleThrow", 5, "두번던짐", 0, 4, 3, 2, "Babarian"));
			SkillOfBabarian[5] = (new Skill("LeapAtk", 6, "점프해서타격", 0, 4, 3, 1, "Babarian"));
			SkillOfBabarian[6] = (new Skill("ConRate", 7, "컨센트레이트", 0, 5, 4, 3, "Babarian"));
			SkillOfBabarian[7] = (new Skill("Frengy", 8, "많이던짐", 0, 10, 4, 4, "Babarian"));
			SkillOfBabarian[8] = (new Skill("WhellWind", 9, "돌면서타격", 0, 10, 10, 5, "Babarian"));
			SkillOfBabarian[9] = (new Skill("Berserk", 10, "버서크", 0, 10, 10, 6, "Babarian"));

			// Bash → Stun → ConRate → Berserk
			// Leap → LeapAtk → WhellWind
			// DoubleSwing → DoubleThrow → Frengy

			SkillOfSorceress[0] = (new Skill("FireVolt", 1, "화염화살마법", 0, 2, 2, 9, "Sorceress"));
			SkillOfSorceress[1] = (new Skill("Wram", 2, "마나회복속도증가", 0, 2, 2, 9, "Sorceress"));
			SkillOfSorceress[2] = (new Skill("Inferno", 3, "요가파이어", 0, 2, 2, 9, "Sorceress"));
			SkillOfSorceress[3] = (new Skill("Blaze", 4, "달리면서불쇼", 0, 4, 3, 2, "Sorceress"));
			SkillOfSorceress[4] = (new Skill("FireBall", 5, "화염공발사", 0, 4, 3, 0, "Sorceress"));
			SkillOfSorceress[5] = (new Skill("FireWall", 6, "불의장막", 0, 4, 3, 3, "Sorceress"));
			SkillOfSorceress[6] = (new Skill("Inchent", 7, "무기화염강화", 0, 5, 4, 1, "Sorceress"));
			SkillOfSorceress[7] = (new Skill("Meteo", 8, "메테오인더하우스", 0, 10, 4, 4, "Sorceress"));
			SkillOfSorceress[8] = (new Skill("FireMastary", 9, "파이어스킬효과증가", 0, 10, 10, 9, "Sorceress"));
			SkillOfSorceress[9] = (new Skill("Hydra", 10, "하일하이드라", 0, 10, 10, 6, "Sorceress"));

			// FireVolt → FireBall → Meteo
			// Inferno → Blaze → FireWall
			// Wram → Inchent → Hydra

		}




		private void SetSkillTree(JobClass jobName)
		{
			switch (jobName)
			{
				case JobClass.Amazon:
                    AmazonSkill1.Visible = true;
					babarianSkill1.Visible = false;
					sorceressSkill1.Visible = false;
					Initstat(jobName);
                    InitSkilltree();
					NowSkillClass = SkillOfAmazon;
					break;
				case JobClass.Babarian:
                    AmazonSkill1.Visible = false;
					babarianSkill1.Visible = true;
					sorceressSkill1.Visible = false;
					Initstat(jobName);
					InitSkilltree();
					NowSkillClass = SkillOfBabarian;
					break;
				case JobClass.Sorceress:
                    AmazonSkill1.Visible = false;
					babarianSkill1.Visible = false;
					sorceressSkill1.Visible = true;
					Initstat(jobName);
					InitSkilltree();
					NowSkillClass = SkillOfSorceress;
					break;
				default:
					break;
			}
		}
	
		public void statUpdate()
		{
			//화면에 텍스트에 업데이트
			StrPoint.Text = playerStat.str.ToString();
			DexPoint.Text = playerStat.dex.ToString();
			VitalPoint.Text = playerStat.vitalty.ToString();
			EnergyPoint.Text = playerStat.energy.ToString();
			StatPoint.Text = playerStat.statPoint.ToString();
			SkillPoint.Text = playerStat.skillPoint.ToString();
			DamegePoint.Text = playerStat.Atk.ToString();
			AttRationPoint.Text = playerStat.AtkRating.ToString();
			SurvivePoint.Text = playerStat.helth.ToString();
			ManaPoint.Text = playerStat.mana.ToString();
			Level.Text = playerStat.level.ToString();
            
            
		}


		private void Initstat(JobClass jobName)
		{
            // 스텟 리셋 part1
			switch (jobName)
			{
				case JobClass.Amazon:
					resetStat(15, 25, 10, 5);
					statUpdate();
					break;
				case JobClass.Babarian:
					resetStat(25, 20, 10, 5);
					statUpdate();
					break;
				case JobClass.Sorceress:
					resetStat(5, 10, 10, 25);
					statUpdate();
					break;
				default:
					break;
			}
		}

		private void resetStat(int str, int dex, int vital, int energy)
		{
            //스텟 리셋 part2
			playerStat.str = str;
			playerStat.dex = dex;
			playerStat.vitalty = vital;
			playerStat.energy = energy;
			playerStat.level = 1;
			playerStat.skillPoint = 0;
			playerStat.statPoint = 0;
			setResultPoint();
            
		}

		private void setResultPoint()
		{
            //resultPoint 계산
			playerStat.Atk = playerStat.str * playerStat.dex;
			playerStat.AtkRating = playerStat.dex * 2;
			playerStat.helth = playerStat.vitalty * playerStat.dex;
			playerStat.mana = playerStat.energy * 3;
            
		}

		private void setStatPoint(int str, int dex, int vita, int energy)
		{
            //스탯 찍으면 포인트 반영
			if (playerStat.statPoint != 0)
			{
				playerStat.str += str;
				playerStat.dex += dex;
				playerStat.vitalty += vita;
				playerStat.energy += energy;
				playerStat.statPoint -= 1;
				setResultPoint();
				statUpdate();
			}
		}

        private void LevelUpButton_Click(object sender, EventArgs e)
		{
			if (playerStat.level < 99)
			{
				playerStat.skillPoint += 1;
				playerStat.statPoint += 5;
				playerStat.level += 1;
				statUpdate();
            }
			
		}

		private void strPlusbutton_Click(object sender, EventArgs e)
		{
			setStatPoint(1, 0, 0, 0);
		}

		private void dexPlusbutton_Click(object sender, EventArgs e)
		{
			setStatPoint(0, 1, 0, 0);
		}

		private void vitaPlusButton_Click(object sender, EventArgs e)
		{
			setStatPoint(0, 0, 1, 0);
		}

		private void EnergyPlusButton_Click(object sender, EventArgs e)
		{
			setStatPoint(0, 0, 0, 1);
		}


		private void SelectButtonAmazon_CheckedChanged(object sender, EventArgs e)
		{
			SetSkillTree(JobClass.Amazon);
		}

		private void SelectButtonBabarian_CheckedChanged(object sender, EventArgs e)
		{
			SetSkillTree(JobClass.Babarian);
		}

		private void SelectButtonSor_CheckedChanged(object sender, EventArgs e)
		{
			SetSkillTree(JobClass.Sorceress);
		}

     
    }


}
