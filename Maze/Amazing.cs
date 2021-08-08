using System;
using System.Text;

namespace Maze
{
    public class Amazing
    {
        private readonly Random _random;

        private StringBuilder _result = new();
        private int _target; // where GOTO goes

        public Amazing(Random random)
        {
            _random = random;
        }

        private void Print(string text)
        {
            _result.Append(text);
        }

        private int Rnd(int count)
        {
            return (int) (count * _random.NextDouble()) + 1;
        }

        private void Goto(int lineno)
        {
            _target = lineno;
        }

        private void PrintHeader()
        {
            Print("Amazing - Copyright by Creative Computing, Morristown, NJ");

            _result.Append(Environment.NewLine);
        }
        
        public string DoIt(int horizontal, int vertical)
        {
            if (horizontal == 1 || vertical == 1)
            {
                throw new ArgumentException("Both height and width were 1.");
            }
            
            PrintHeader();

            var h = horizontal;
            var v = vertical;

            int[,] wArray = new int[h + 1, v + 1];
            int[,] vArray = new int[h + 1, v + 1];

            var q = 0;
            var z = 0;
            var x = Rnd(h);

            // 130:170
            for (var i = 1; i <= h; i++)
            {
                Print(i == x ? ":  " : ":--");
            }

            // 180
            Print(":");
            _result.Append(Environment.NewLine);

            // 190
            var c = 1;
            wArray[x, 1] = c;
            c++;

            // 200
            var r = x;
            var s = 1;
            Goto(270);

            DrawMaze(r, h, s, v, wArray, x, z, q, c, vArray);

            PostWhileLoop(v, h, vArray);

            return _result.ToString();
        }

        private void DrawMaze(int r, int h, int s, int v, int[,] wArray, int x, int z, int q, int c, int[,] vArray)
        {
            while (_target != -1)
            {
                switch (_target)
                {
                    case 210:
                        Goto(r != h ? 250 : 220);
                        continue;
                    case 220:
                        Goto(s != v ? 240 : 230);
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
                        Goto(wArray[r, s] == 0 ? 210 : 270);
                        continue;
                    case 270:
                        Goto(r - 1 == 0 ? 600 : 280);
                        continue;
                    case 280:
                        Goto(wArray[r - 1, s] != 0 ? 600 : 290);
                        continue;
                    case 290:
                        Goto(s - 1 == 0 ? 430 : 300);
                        continue;
                    case 300:
                        Goto(wArray[r, s - 1] != 0 ? 430 : 310);
                        continue;
                    case 310:
                        Goto(r == h ? 350 : 320);
                        continue;
                    case 320:
                        Goto(wArray[r + 1, s] != 0 ? 350 : 330);
                        continue;
                    case 330:
                        x = Rnd(3);
                        Goto(340);
                        continue;
                    case 340:
                        switch (x)
                        {
                            case 1:
                                Goto(940);
                                break;
                            case 2:
                                Goto(980);
                                break;
                            case 3:
                                Goto(1020);
                                break;
                            default:
                                Goto(350);
                                break;
                        }

                        continue;
                    case 350:
                        Goto(s != v ? 380 : 360);
                        continue;
                    case 360:
                        Goto(z == 1 ? 410 : 370);
                        continue;
                    case 370:
                        q = 1;
                        Goto(390);
                        continue;
                    case 380:
                        Goto(wArray[r, s + 1] != 0 ? 410 : 390);
                        continue;
                    case 390:
                        x = Rnd(3);
                        Goto(400);
                        continue;
                    case 400:
                        switch (x)
                        {
                            case 1:
                                Goto(940);
                                break;
                            case 2:
                                Goto(980);
                                break;
                            case 3:
                                Goto(1090);
                                break;
                            default:
                                Goto(410);
                                break;
                        }

                        continue;
                    case 410:
                        x = Rnd(2);
                        Goto(420);
                        continue;
                    case 420:
                        switch (x)
                        {
                            case 1:
                                Goto(940);
                                break;
                            case 2:
                                Goto(980);
                                break;
                            default:
                                Goto(430);
                                break;
                        }

                        continue;
                    case 430:
                        Goto(r == h ? 530 : 440);
                        continue;
                    case 440:
                        Goto(wArray[r + 1, s] != 0 ? 530 : 450);
                        continue;
                    case 450:
                        Goto(s != v ? 480 : 460);
                        continue;
                    case 460:
                        Goto(z == 1 ? 510 : 470);
                        continue;
                    case 470:
                        q = 1;
                        Goto(490);
                        continue;
                    case 480:
                        Goto(wArray[r, s + 1] != 0 ? 510 : 490);
                        continue;
                    case 490:
                        x = Rnd(3);
                        Goto(500);
                        continue;
                    case 500:
                        switch (x)
                        {
                            case 1:
                                Goto(940);
                                break;
                            case 2:
                                Goto(1020);
                                break;
                            case 3:
                                Goto(1090);
                                break;
                            default:
                                Goto(510);
                                break;
                        }

                        continue;
                    case 510:
                        x = Rnd(2);
                        Goto(520);
                        continue;
                    case 520:
                        switch (x)
                        {
                            case 1:
                                Goto(940);
                                break;
                            case 2:
                                Goto(1020);
                                break;
                            default:
                                Goto(530);
                                break;
                        }

                        continue;
                    case 530:
                        Goto(s != v ? 560 : 540);
                        continue;
                    case 540:
                        Goto(z == 1 ? 590 : 550);
                        continue;
                    case 550:
                        q = 1;
                        Goto(570);
                        continue;
                    case 560:
                        Goto(wArray[r, s + 1] != 0 ? 590 : 570);
                        continue;
                    case 570:
                        x = Rnd(2);
                        Goto(580);
                        continue;
                    case 580:
                        switch (x)
                        {
                            case 1:
                                Goto(940);
                                break;
                            case 2:
                                Goto(1090);
                                break;
                            default:
                                Goto(590);
                                break;
                        }

                        continue;
                    case 590:
                        Goto(940);
                        continue;
                    case 600:
                        Goto(s - 1 == 0 ? 790 : 610);
                        continue;
                    case 610:
                        Goto(wArray[r, s - 1] != 0 ? 790 : 620);
                        continue;
                    case 620:
                        Goto(r == h ? 720 : 630);
                        continue;
                    case 630:
                        Goto(wArray[r + 1, s] != 0 ? 720 : 640);
                        continue;
                    case 640:
                        Goto(s != v ? 670 : 650);
                        continue;
                    case 650:
                        Goto(z == 1 ? 700 : 660);
                        continue;
                    case 660:
                        q = 1;
                        Goto(680);
                        continue;
                    case 670:
                        Goto(wArray[r, s + 1] != 0 ? 700 : 680);
                        continue;
                    case 680:
                        x = Rnd(3);
                        Goto(690);
                        continue;
                    case 690:
                        switch (x)
                        {
                            case 1:
                                Goto(980);
                                break;
                            case 2:
                                Goto(1020);
                                break;
                            case 3:
                                Goto(1090);
                                break;
                            default:
                                Goto(700);
                                break;
                        }

                        continue;
                    case 700:
                        x = Rnd(2);
                        Goto(710);
                        continue;
                    case 710:
                        switch (x)
                        {
                            case 1:
                                Goto(980);
                                break;
                            case 2:
                                Goto(1020);
                                break;
                            default:
                                Goto(720);
                                break;
                        }

                        continue;
                    case 720:
                        Goto(s != v ? 750 : 730);
                        continue;
                    case 730:
                        Goto(z == 1 ? 780 : 740);
                        continue;
                    case 740:
                        q = 1;
                        Goto(760);
                        continue;
                    case 750:
                        Goto(wArray[r, s + 1] != 0 ? 780 : 760);
                        continue;
                    case 760:
                        x = Rnd(2);
                        Goto(770);
                        continue;
                    case 770:
                        switch (x)
                        {
                            case 1:
                                Goto(980);
                                break;
                            case 2:
                                Goto(1090);
                                break;
                            default:
                                Goto(780);
                                break;
                        }

                        continue;
                    case 780:
                        Goto(980);
                        continue;
                    case 790:
                        Goto(r == h ? 880 : 800);
                        continue;
                    case 800:
                        Goto(wArray[r + 1, s] != 0 ? 880 : 810);
                        continue;
                    case 810:
                        Goto(s != v ? 840 : 820);
                        continue;
                    case 820:
                        Goto(z == 1 ? 870 : 830);
                        continue;
                    case 830:
                        q = 1;
                        Goto(990);
                        continue;
                    case 840:
                        Goto(wArray[r, s + 1] != 0 ? 870 : 850);
                        continue;
                    case 850:
                        x = Rnd(2);
                        Goto(860);
                        continue;
                    case 860:
                        switch (x)
                        {
                            case 1:
                                Goto(1020);
                                break;
                            case 2:
                                Goto(1090);
                                break;
                            default:
                                Goto(870);
                                break;
                        }

                        continue;
                    case 870:
                        Goto(1020);
                        continue;
                    case 880:
                        Goto(s != v ? 910 : 890);
                        continue;
                    case 890:
                        Goto(z == 1 ? 930 : 900);
                        continue;
                    case 900:
                        q = 1;
                        Goto(920);
                        continue;
                    case 910:
                        Goto(wArray[r, s + 1] != 0 ? 930 : 920);
                        continue;
                    case 920:
                        Goto(1090);
                        continue;
                    case 930:
                        Goto(1190);
                        continue;
                    case 940:
                        wArray[r - 1, s] = c;
                        Goto(950);
                        continue;
                    case 950:
                        c++;
                        vArray[r - 1, s] = 2;
                        r--;
                        Goto(960);
                        continue;
                    case 960:
                        Goto(c == h * v + 1 ? 1200 : 970);
                        continue;
                    case 970:
                        q = 0;
                        Goto(270);
                        continue;
                    case 980:
                        wArray[r, s - 1] = c;
                        Goto(990);
                        continue;
                    case 990:
                        c++;
                        Goto(1000);
                        continue;
                    case 1000:
                        vArray[r, s - 1] = 1;
                        s--;
                        Goto(c == h * v + 1 ? 1200 : 1010);
                        continue;
                    case 1010:
                        q = 0;
                        Goto(270);
                        continue;
                    case 1020:
                        wArray[r + 1, s] = c;
                        Goto(1030);
                        continue;
                    case 1030:
                        c++;
                        Goto(vArray[r, s] == 0 ? 1050 : 1040);
                        continue;
                    case 1040:
                        vArray[r, s] = 3;
                        Goto(1060);
                        continue;
                    case 1050:
                        vArray[r, s] = 2;
                        Goto(1060);
                        continue;
                    case 1060:
                        r++;
                        Goto(1070);
                        continue;
                    case 1070:
                        Goto(c == h * v + 1 ? 1200 : 1080);
                        continue;
                    case 1080:
                        Goto(600);
                        continue;
                    case 1090:
                        Goto(q == 1 ? 1150 : 1100);
                        continue;
                    case 1100:
                        wArray[r, s + 1] = c;
                        c++;
                        Goto(vArray[r, s] == 0 ? 1120 : 1110);
                        continue;
                    case 1110:
                        vArray[r, s] = 3;
                        Goto(1130);
                        continue;
                    case 1120:
                        vArray[r, s] = 1;
                        Goto(1130);
                        continue;
                    case 1130:
                        s++;
                        Goto(c == v * h + 1 ? 1200 : 1140);
                        continue;
                    case 1140:
                        Goto(270);
                        continue;
                    case 1150:
                        z = 1;
                        Goto(1160);
                        continue;
                    case 1160:
                        Goto(vArray[r, s] == 0 ? 1180 : 1170);
                        continue;
                    case 1170:
                        vArray[r, s] = 3;
                        q = 0;
                        Goto(1190);
                        continue;
                    case 1180:
                        vArray[r, s] = 1;
                        q = 0;
                        r = 1;
                        s = 1;
                        Goto(260);
                        continue;
                    case 1190:
                        Goto(210);
                        continue;
                    case 1200:
                        _target = -1;
                        continue;
                }
            }
        }

        private void PostWhileLoop(int v, int h, int[,] vArray)
        {
            // 1200:
            for (var j = 1; j <= v; j++)
            {
                Print("I"); // 1210

                for (var i = 1; i <= h; i++)
                {
                    Print(vArray[i, j] >= 2 ? "   " : "  I");
                }

                Print(" "); // 1280
                _result.Append(Environment.NewLine);

                for (var i = 1; i <= h; i++)
                {
                    switch (vArray[i, j])
                    {
                        case 0:
                        // 1310, 1340
                        case 2:
                            Print(":--"); // 1300, 1340
                            break;
                        default:
                            Print(":  "); // 1320
                            break;
                    }
                }

                Print(":"); // 1360
                _result.Append(Environment.NewLine);
            }
        }
    }
}