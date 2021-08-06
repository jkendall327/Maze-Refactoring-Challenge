using System;

public class Amazing
{
	private readonly Random _random;

	private string Result = string.Empty;

	private int Target = 0;      // where GOTO goes

    public Amazing(Random random)
    {
        _random = random;
    }

	private void Print(String text) 
	{
		Result += text;
	}

	private int Rnd(int count) 
	{
		return (int) (count * _random.NextDouble()) + 1;
	}

	private void Goto(int lineno) 
	{
		Target = lineno;
	}

	public string DoIt(int horizontal, int vertical) 
	{
		Result = string.Empty;

		Print("Amazing - Copyright by Creative Computing, Morristown, NJ");
		
		Result += Environment.NewLine;

		int h = horizontal;
		int v = vertical;

		if (h == 1 || v == 1)
		{
			throw new ArgumentException("Both height and width were 1.");
		}

		int[,] wArray = new int[h + 1,v + 1];
		

		int[,] vArray = new int[h + 1,v + 1];
		

		int q = 0;
		int z = 0;
		int x = Rnd(h);

		// 130:170
		for (int i = 1; i <= h; i++) 
		{
			if (i == x)
				Print(":  ");
			else
				Print(":--");
		}
		// 180
		Print(":");
		Result += Environment.NewLine;

		// 190
		int c = 1;
		wArray[x,1] = c;
		c++;

		// 200
		int r = x;
		int s = 1;
		Goto(270);

		while (Target != -1) 
		{
			switch (Target) 
			{
				case 210:
					if (r != h)
						Goto(250);
					else
						Goto(220);
					continue;
				case 220:
					if (s != v)
						Goto(240);
					else
						Goto(230);
					continue;
				case 230:
					r = 1;
					s = 1;
					Goto(260);
					continue;
				case 240:
					r = 1;
					s++;
					Goto(260);
					continue;
				case 250:
					r++;
					Goto(260);
					continue;
				case 260:
					if (wArray[r,s] == 0)
						Goto(210);
					else
						Goto(270);
					continue;
				case 270:
					if (r - 1 == 0)
						Goto(600);
					else
						Goto(280);
					continue;
				case 280:
					if (wArray[r - 1,s] != 0)
						Goto(600);
					else
						Goto(290);
					continue;
				case 290:
					if (s - 1 == 0)
						Goto(430);
					else
						Goto(300);
					continue;
				case 300:
					if (wArray[r,s - 1] != 0)
						Goto(430);
					else
						Goto(310);
					continue;
				case 310:
					if (r == h)
						Goto(350);
					else
						Goto(320);
					continue;
				case 320:
					if (wArray[r + 1,s] != 0)
						Goto(350);
					else
						Goto(330);
					continue;
				case 330:
					x = Rnd(3);
					Goto(340);
					continue;
				case 340:
					if (x == 1)
						Goto(940);
					else if (x == 2)
						Goto(980);
					else if (x == 3)
						Goto(1020);
					else
						Goto(350);
					continue;
				case 350:
					if (s != v)
						Goto(380);
					else
						Goto(360);
					continue;
				case 360:
					if (z == 1)
						Goto(410);
					else
						Goto(370);
					continue;
				case 370:
					q = 1;
					Goto(390);
					continue;
				case 380:
					if (wArray[r,s + 1] != 0)
						Goto(410);
					else
						Goto(390);
					continue;
				case 390:
					x = Rnd(3);
					Goto(400);
					continue;
				case 400:
					if (x == 1)
						Goto(940);
					else if (x == 2)
						Goto(980);
					else if (x == 3)
						Goto(1090);
					else
						Goto(410);
					continue;
				case 410:
					x = Rnd(2);
					Goto(420);
					continue;
				case 420:
					if (x == 1)
						Goto(940);
					else if (x == 2)
						Goto(980);
					else
						Goto(430);
					continue;
				case 430:
					if (r == h)
						Goto(530);
					else
						Goto(440);
					continue;
				case 440:
					if (wArray[r + 1,s] != 0)
						Goto(530);
					else
						Goto(450);
					continue;
				case 450:
					if (s != v)
						Goto(480);
					else
						Goto(460);
					continue;
				case 460:
					if (z == 1)
						Goto(510);
					else
						Goto(470);
					continue;
				case 470:
					q = 1;
					Goto(490);
					continue;
				case 480:
					if (wArray[r,s + 1] != 0)
						Goto(510);
					else
						Goto(490);
					continue;
				case 490:
					x = Rnd(3);
					Goto(500);
					continue;
				case 500:
					if (x == 1)
						Goto(940);
					else if (x == 2)
						Goto(1020);
					else if (x == 3)
						Goto(1090);
					else
						Goto(510);
					continue;
				case 510:
					x = Rnd(2);
					Goto(520);
					continue;
				case 520:
					if (x == 1)
						Goto(940);
					else if (x == 2)
						Goto(1020);
					else
						Goto(530);
					continue;
				case 530:
					if (s != v)
						Goto(560);
					else
						Goto(540);
					continue;
				case 540:
					if (z == 1)
						Goto(590);
					else
						Goto(550);
					continue;
				case 550:
					q = 1;
					Goto(570);
					continue;
				case 560:
					if (wArray[r,s + 1] != 0)
						Goto(590);
					else
						Goto(570);
					continue;
				case 570:
					x = Rnd(2);
					Goto(580);
					continue;
				case 580:
					if (x == 1)
						Goto(940);
					else if (x == 2)
						Goto(1090);
					else
						Goto(590);
					continue;
				case 590:
					Goto(940);
					continue;
				case 600:
					if (s - 1 == 0)
						Goto(790);
					else
						Goto(610);
					continue;
				case 610:
					if (wArray[r,s - 1] != 0)
						Goto(790);
					else
						Goto(620);
					continue;
				case 620:
					if (r == h)
						Goto(720);
					else
						Goto(630);
					continue;
				case 630:
					if (wArray[r + 1,s] != 0)
						Goto(720);
					else
						Goto(640);
					continue;
				case 640:
					if (s != v)
						Goto(670);
					else
						Goto(650);
					continue;
				case 650:
					if (z == 1)
						Goto(700);
					else
						Goto(660);
					continue;
				case 660:
					q = 1;
					Goto(680);
					continue;
				case 670:
					if (wArray[r,s + 1] != 0)
						Goto(700);
					else
						Goto(680);
					continue;
				case 680:
					x = Rnd(3);
					Goto(690);
					continue;
				case 690:
					if (x == 1)
						Goto(980);
					else if (x == 2)
						Goto(1020);
					else if (x == 3)
						Goto(1090);
					else
						Goto(700);
					continue;
				case 700:
					x = Rnd(2);
					Goto(710);
					continue;
				case 710:
					if (x == 1)
						Goto(980);
					else if (x == 2)
						Goto(1020);
					else
						Goto(720);
					continue;
				case 720:
					if (s != v)
						Goto(750);
					else
						Goto(730);
					continue;
				case 730:
					if (z == 1)
						Goto(780);
					else
						Goto(740);
					continue;
				case 740:
					q = 1;
					Goto(760);
					continue;
				case 750:
					if (wArray[r,s + 1] != 0)
						Goto(780);
					else
						Goto(760);
					continue;
				case 760:
					x = Rnd(2);
					Goto(770);
					continue;
				case 770:
					if (x == 1)
						Goto(980);
					else if (x == 2)
						Goto(1090);
					else
						Goto(780);
					continue;
				case 780:
					Goto(980);
					continue;
				case 790:
					if (r == h)
						Goto(880);
					else
						Goto(800);
					continue;
				case 800:
					if (wArray[r + 1,s] != 0)
						Goto(880);
					else
						Goto(810);
					continue;
				case 810:
					if (s != v)
						Goto(840);
					else
						Goto(820);
					continue;
				case 820:
					if (z == 1)
						Goto(870);
					else
						Goto(830);
					continue;
				case 830:
					q = 1;
					Goto(990);
					continue;
				case 840:
					if (wArray[r,s + 1] != 0)
						Goto(870);
					else
						Goto(850);
					continue;
				case 850:
					x = Rnd(2);
					Goto(860);
					continue;
				case 860:
					if (x == 1)
						Goto(1020);
					else if (x == 2)
						Goto(1090);
					else
						Goto(870);
					continue;
				case 870:
					Goto(1020);
					continue;
				case 880:
					if (s != v)
						Goto(910);
					else
						Goto(890);
					continue;
				case 890:
					if (z == 1)
						Goto(930);
					else
						Goto(900);
					continue;
				case 900:
					q = 1;
					Goto(920);
					continue;
				case 910:
					if (wArray[r,s + 1] != 0)
						Goto(930);
					else
						Goto(920);
					continue;
				case 920:
					Goto(1090);
					continue;
				case 930:
					Goto(1190);
					continue;
				case 940:
					wArray[r - 1,s] = c;
					Goto(950);
					continue;
				case 950:
					c++;
					vArray[r - 1,s] = 2;
					r--;
					Goto(960);
					continue;
				case 960:
					if (c == h * v + 1)
						Goto(1200);
					else
						Goto(970);
					continue;
				case 970:
					q = 0;
					Goto(270);
					continue;
				case 980:
					wArray[r,s - 1] = c;
					Goto(990);
					continue;
				case 990:
					c++;
					Goto(1000);
					continue;
				case 1000:
					vArray[r,s - 1] = 1;
					s--;
					if (c == h * v + 1)
						Goto(1200);
					else
						Goto(1010);
					continue;
				case 1010:
					q = 0;
					Goto(270);
					continue;
				case 1020:
					wArray[r + 1,s] = c;
					Goto(1030);
					continue;
				case 1030:
					c++;
					if (vArray[r,s] == 0)
						Goto(1050);
					else
						Goto(1040);
					continue;
				case 1040:
					vArray[r,s] = 3;
					Goto(1060);
					continue;
				case 1050:
					vArray[r,s] = 2;
					Goto(1060);
					continue;
				case 1060:
					r++;
					Goto(1070);
					continue;
				case 1070:
					if (c == h * v + 1)
						Goto(1200);
					else
						Goto(1080);
					continue;
				case 1080:
					Goto(600);
					continue;
				case 1090:
					if (q == 1)
						Goto(1150);
					else
						Goto(1100);
					continue;
				case 1100:
					wArray[r,s + 1] = c;
					c++;
					if (vArray[r,s] == 0)
						Goto(1120);
					else
						Goto(1110);
					continue;
				case 1110:
					vArray[r,s] = 3;
					Goto(1130);
					continue;
				case 1120:
					vArray[r,s] = 1;
					Goto(1130);
					continue;
				case 1130:
					s++;
					if (c == v * h + 1)
						Goto(1200);
					else
						Goto(1140);
					continue;
				case 1140:
					Goto(270);
					continue;
				case 1150:
					z = 1;
					Goto(1160);
					continue;
				case 1160:
					if (vArray[r,s] == 0)
						Goto(1180);
					else
						Goto(1170);
					continue;
				case 1170:
					vArray[r,s] = 3;
					q = 0;
					Goto(1190);
					continue;
				case 1180:
					vArray[r,s] = 1;
					q = 0;
					r = 1;
					s = 1;
					Goto(260);
					continue;
				case 1190:
					Goto(210);
					continue;
				case 1200:
					Target = -1;
					continue;
			}

		}

		// 1200:
		for (int j = 1; j <= v; j++) 
		{
			Print("I");        // 1210

			for (int i = 1; i <= h; i++) 
			{
				if (vArray[i,j] >= 2)
					Print("   ");  // 1240
				else
					Print("  I");  // 1260
			}

			Print(" ");   // 1280
			Result += Environment.NewLine;

			for (int i = 1; i <= h; i++) 
			{
				if (vArray[i,j] == 0)
					Print(":--");   // 1300, 1340
				else if (vArray[i,j] == 2)
					Print(":--");  // 1310, 1340
				else
					Print(":  "); // 1320
			}

			Print(":");    // 1360
			Result += Environment.NewLine;
		}

		return Result;
	}
}
