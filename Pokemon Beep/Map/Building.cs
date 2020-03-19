using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Beep
{
    class Building
    {
        private int posX, posY, buildingID;
        private string buildingClass;
        public Building(int posX, int posY, string buildingClass, int buildingID)
        {
            this.posX = posX;
            this.posY = posY;
            this.buildingClass = buildingClass;
            this.buildingID = buildingID;
        }
        public void writeBuilding()
        {
            switch(buildingClass)
            {
                case "house":
                    if(buildingID == 1)
                    {
                        Console.SetCursorPosition(posX, posY);
                        posY++;
                        Console.WriteLine("   ________________");
                        Console.SetCursorPosition(posX, posY);
                        posY++;
                        Console.WriteLine("  /                \\");
                        Console.SetCursorPosition(posX, posY);
                        posY++;
                        Console.WriteLine(" /__________________\\");
                        Console.SetCursorPosition(posX, posY);
                        posY++;
                        Console.WriteLine(" |     _     [][]   |");
                        Console.SetCursorPosition(posX, posY);
                        posY++;
                        Console.WriteLine(" |    /o\\    [][]   |");
                        Console.SetCursorPosition(posX, posY);
                        Console.WriteLine(" |____|_|___________|  ");
                        break;
                    }
                    else if(buildingID == 2)
                    {
                        Console.SetCursorPosition(posX, posY);
                        posY++;
                        Console.WriteLine("               __ ");
                        Console.SetCursorPosition(posX, posY);
                        posY++;
                        Console.WriteLine("   ___________:  :___");
                        Console.SetCursorPosition(posX, posY);
                        posY++;
                        Console.WriteLine("  /           :  :   \\");
                        Console.SetCursorPosition(posX, posY);
                        posY++;
                        Console.WriteLine(" /____________________\\");
                        Console.SetCursorPosition(posX, posY);
                        posY++;
                        Console.WriteLine(" |     _       [][]   |");
                        Console.SetCursorPosition(posX, posY);
                        posY++;
                        Console.WriteLine(" |    /o\\      [][]   |");
                        Console.SetCursorPosition(posX, posY);
                        Console.WriteLine(" |____|_|_____________|  ");
                    }
                    else if(buildingID == 3)
                    {
                        Console.SetCursorPosition(posX, posY);
                        posY++;
                        Console.WriteLine("  ____________/\\____");
                        Console.SetCursorPosition(posX, posY);
                        posY++;
                        Console.WriteLine(" /           /  \\   \\");
                        Console.SetCursorPosition(posX, posY);
                        posY++;
                        Console.WriteLine("/___________/_[]_\\___\\");
                        Console.SetCursorPosition(posX, posY);
                        posY++;
                        Console.WriteLine(" |         /      \\  |");
                        Console.SetCursorPosition(posX, posY);
                        posY++;
                        Console.WriteLine(" |   _      [][]     |");
                        Console.SetCursorPosition(posX, posY);
                        posY++;
                        Console.WriteLine(" |  /o\\     [][]     |");
                        Console.SetCursorPosition(posX, posY);
                        Console.WriteLine(" |__|_|______________|");
                    }
                    break;
                case "lab":
                    Console.SetCursorPosition(posX, posY);
                    posY++;
                    Console.WriteLine(" _______________");
                    Console.SetCursorPosition(posX, posY);
                    posY++;
                    Console.WriteLine("|               |");
                    Console.SetCursorPosition(posX, posY);
                    posY++;
                    Console.WriteLine("|_______________|");
                    Console.SetCursorPosition(posX, posY);
                    posY++;
                    Console.WriteLine("|      LAB      | ");
                    Console.SetCursorPosition(posX, posY);
                    posY++;
                    Console.WriteLine("| [][] /o\\ [][] |");
                    Console.SetCursorPosition(posX, posY);
                    Console.WriteLine("|______|_|______| ");
                    break;
                case "interior":
                    if(buildingID == 1)
                    {
                        Console.SetWindowSize(121, 37);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.SetCursorPosition(45, 10);
                        Console.WriteLine(" ________________________________");
                        Console.SetCursorPosition(45, 11);
                        Console.WriteLine("|                                |");
                        Console.SetCursorPosition(45, 12);
                        Console.WriteLine("|                                |");
                        Console.SetCursorPosition(45, 13);
                        Console.WriteLine("|                                |");
                        Console.SetCursorPosition(45, 14);
                        Console.WriteLine("|________________________________|");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(45, 15);
                        Console.WriteLine("|                                |");
                        Console.SetCursorPosition(45, 16);
                        Console.WriteLine("|                                |");
                        Console.SetCursorPosition(45, 17);
                        Console.WriteLine("|                                |");
                        Console.SetCursorPosition(45, 18);
                        Console.WriteLine("|                                |");
                        Console.SetCursorPosition(45, 19);
                        Console.WriteLine("|                                |");
                        Console.SetCursorPosition(45, 20);
                        Console.WriteLine("|                                |");
                        Console.SetCursorPosition(45, 21);
                        Console.WriteLine("|                                |");
                        Console.SetCursorPosition(45, 22);
                        Console.WriteLine("|                                |");
                        Console.SetCursorPosition(45, 23);
                        Console.WriteLine("|      ___                       |");
                        Console.SetCursorPosition(45, 24);
                        Console.WriteLine("|_____|___|______________________|");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(49, 12);
                        Console.WriteLine("'-.-.");
                        Console.SetCursorPosition(50, 13);
                        Console.WriteLine("'|'.");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.SetCursorPosition(50, 14);
                        Console.WriteLine("[_]");

                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.SetCursorPosition(73, 15);
                        Console.WriteLine("____");
                        Console.SetCursorPosition(72, 16);
                        Console.WriteLine("||__||");
                        Console.SetCursorPosition(72, 17);
                        Console.WriteLine("|    |");
                        Console.SetCursorPosition(72, 18);
                        Console.WriteLine("|____|");

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(52, 16);
                        Console.WriteLine("|░░░░░░░░░░░░░░░░|");
                        Console.SetCursorPosition(52, 17);
                        Console.WriteLine("|░░░░░░░░░░░░░░░░|");
                        Console.SetCursorPosition(52, 18);
                        Console.WriteLine("|░░░░░░░░░░░░░░░░|");
                        Console.SetCursorPosition(52, 19);
                        Console.WriteLine("|░░░░░░░░░░░░░░░░|");
                        Console.SetCursorPosition(52, 20);
                        Console.WriteLine("|░░░░░░░░░░░░░░░░|");
                        Console.SetCursorPosition(52, 21);
                        Console.WriteLine("|░░░░░░░░░░░░░░░░|");
                        Console.SetCursorPosition(52, 22);
                        Console.WriteLine("|░░░░░░░░░░░░░░░░|");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(56, 18);
                        Console.WriteLine("|¯¯¯¯¯¯¯|");
                        Console.SetCursorPosition(56, 19);
                        Console.WriteLine("|     o |");
                        Console.SetCursorPosition(56, 20);
                        Console.WriteLine("|_______|");
                        Console.SetCursorPosition(57, 21);
                        Console.WriteLine("|");
                        Console.SetCursorPosition(63, 21);
                        Console.WriteLine("|");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(72, 11);
                        Console.WriteLine("_");
                        Console.SetCursorPosition(71, 12);
                        Console.WriteLine(":_:");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(73, 19);
                        Console.WriteLine("___");
                        Console.SetCursorPosition(72, 20);
                        Console.WriteLine("|   |");
                        Console.SetCursorPosition(72, 21);
                        Console.WriteLine("|___|");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.SetCursorPosition(73, 22);
                        Console.WriteLine("|_|");
                    }
                    break;
                case "border":
                    if(buildingID == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine("  ()    ()    ()    ()    ()    ()    ()    ()    ()    ()    ()    ()    ()    ()    ()    ()    ()    ()    ()    ()");
                        Console.WriteLine(" (  )  (  )  (  )  (  )  (  )  (  )  (  )  (  )  (  )  (  )  (  )  (  )  (  )  (  )  (  )  (  )  (  )  (  )  (  )  (  ) ");
                        Console.WriteLine("(____)(____)(____)(____)(____)(____)(____)(____)(____)(____)(____)(____)(____)(____)(____)(____)(____)(____)(____)(____)");
                        Console.WriteLine("  )(    )(    )(    )(    )(    )(    )(    )(    )(    )(    )(    )(    )(    )(    )(    )(    )(    )(    )(    )( ");
                        Console.WriteLine("  ()                                                                                                                ()");
                        Console.WriteLine(" (  )                                                                                                              (  )");
                        Console.WriteLine("(____)                                                                                                            (____)");
                        Console.WriteLine("  )(                                                                                                                )( ");
                        Console.WriteLine("  ()                                                                                                                ()");
                        Console.WriteLine(" (  )                                                                                                              (  )");
                        Console.WriteLine("(____)                                                                                                            (____)");
                        Console.WriteLine("  )(                                                                                                                )( ");
                        Console.WriteLine("  ()                                                                                                                ()");
                        Console.WriteLine(" (  )                                                                                                              (  )");
                        Console.WriteLine("(____)                                                                                                            (____)");
                        Console.WriteLine("  )(                                                                                                                )( ");
                        Console.WriteLine("  ()                                                                                                                ()");
                        Console.WriteLine(" (  )                                                                                                              (  )");
                        Console.WriteLine("(____)                                                                                                            (____)");
                        Console.WriteLine("  )(                                                                                                                )( ");
                        Console.WriteLine("  ()  ");
                        Console.WriteLine(" (  )");
                        Console.WriteLine("(____)");
                        Console.WriteLine("  )( ");
                        Console.WriteLine("  ()                                                                                                                ()");
                        Console.WriteLine(" (  )                                                                                                              (  )");
                        Console.WriteLine("(____)                                                                                                            (____)");
                        Console.WriteLine("  )(                                                                                                                )( ");
                        Console.WriteLine("  ()                                                                                                                ()");
                        Console.WriteLine(" (  )                                                                                                              (  )");
                        Console.WriteLine("(____)                                                                                                            (____)");
                        Console.WriteLine("  )(                                                                                                                )( ");
                        Console.WriteLine("  ()    ()    ()    ()    ()    ()    ()    ()    ()    ()    ()    ()    ()    ()    ()    ()    ()    ()    ()    ()  ");
                        Console.WriteLine(" (  )  (  )  (  )  (  )  (  )  (  )  (  )  (  )  (  )  (  )  (  )  (  )  (  )  (  )  (  )  (  )  (  )  (  )  (  )  (  )");
                        Console.WriteLine("(____)(____)(____)(____)(____)(____)(____)(____)(____)(____)(____)(____)(____)(____)(____)(____)(____)(____)(____)(____)");
                        Console.WriteLine("  )(    )(    )(    )(    )(    )(    )(    )(    )(    )(    )(    )(    )(    )(    )(    )(    )(    )(    )(    )(  ");
                    }
                    break;
                case "decoration":
                    if(buildingID == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.SetCursorPosition(posX, posY);
                        posY++;
                        Console.WriteLine(" ____________________________");
                        Console.SetCursorPosition(posX, posY);
                        Console.Write("|");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("████████████████████████████");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("|");
                        Console.SetCursorPosition(posX, posY);
                        posY++;
                        Console.Write("|");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("████████████████████████████");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("|");
                        Console.SetCursorPosition(posX, posY);
                        posY++;
                        Console.Write("|");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("████████████████████████████");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("|");
                        Console.SetCursorPosition(posX, posY);
                        posY++;
                        Console.Write("|");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("████████████████████████████");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("|");
                        Console.SetCursorPosition(posX, posY);
                        posY++;
                        Console.Write("|");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("████████████████████████████");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("|");
                        Console.SetCursorPosition(posX, posY);
                        posY++;
                        Console.Write("|");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("████████████████████████████");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("|");
                        Console.SetCursorPosition(posX, posY);
                        Console.Write("|");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("████████████████████████████");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("|");
                    }
                    break;
                case "road":
                    if(buildingID == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.SetCursorPosition(37, 27);
                        Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
                        Console.SetCursorPosition(37, 28);
                        Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
                        Console.SetCursorPosition(37, 29);
                        Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");

                        Console.SetCursorPosition(10, 12);
                        Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
                        Console.SetCursorPosition(10, 13);
                        Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
                        Console.SetCursorPosition(10, 14);
                        Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");

                        Console.SetCursorPosition(103, 21);
                        Console.WriteLine("░░░░░░░░░░░░░░░░░░");
                        Console.SetCursorPosition(103, 22);
                        Console.WriteLine("░░░░░░░░░░░░░░░░░░");
                        Console.SetCursorPosition(103, 23);
                        Console.WriteLine("░░░░░░░░░░░░░░░░░░");

                        Console.SetCursorPosition(103, 12);
                        Console.WriteLine("░░░░░");
                        Console.SetCursorPosition(103, 13);
                        Console.WriteLine("░░░░░");
                        Console.SetCursorPosition(103, 14);
                        Console.WriteLine("░░░░░");
                        Console.SetCursorPosition(103, 15);
                        Console.WriteLine("░░░░░");
                        Console.SetCursorPosition(103, 16);
                        Console.WriteLine("░░░░░");
                        Console.SetCursorPosition(103, 17);
                        Console.WriteLine("░░░░░");
                        Console.SetCursorPosition(103, 18);
                        Console.WriteLine("░░░░░");
                        Console.SetCursorPosition(103, 19);
                        Console.WriteLine("░░░░░");
                        Console.SetCursorPosition(103, 20);
                        Console.WriteLine("░░░░░");
                        Console.SetCursorPosition(103, 21);
                        Console.WriteLine("░░░░░");
                        Console.SetCursorPosition(103, 22);
                        Console.WriteLine("░░░░░");
                        Console.SetCursorPosition(103, 23);
                        Console.WriteLine("░░░░░");
                        Console.SetCursorPosition(103, 24);
                        Console.WriteLine("░░░░░");
                        Console.SetCursorPosition(103, 25);
                        Console.WriteLine("░░░░░");
                        Console.SetCursorPosition(103, 26);
                        Console.WriteLine("░░░░░");
                    }
                    break;
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
