﻿using System;

namespace Оператор_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            // в свитч передают какое то число, строку или эйНам, а в if булевое значение

            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    {
                        Console.WriteLine("Вы ввели число 1");
                        break;
                    }

                case 2:
                    Console.WriteLine("Вы ввели число 2");
                    break;

                case 3:
                case 4:
                    Console.WriteLine("Вы ввели число 3 или 4");
                    break;

                default:    // default это означет порядок действий, который должны выполнять прога если число не совпадает со значениями кейса
                    Console.WriteLine("Another number");
                    break;
            }

            Console.WriteLine("Enter world");
            string b = Console.ReadLine();
            switch (b)
            {
                case "world":
                    Console.WriteLine("You enter world");
                    break;

                default:
                    Console.WriteLine("You enter somethink another");
                    break;
            }

            ConsoleKey consoleKey = Console.ReadKey().Key;
            switch (consoleKey)
            {
                case ConsoleKey.A:
                    Console.WriteLine("Вы нажали а");
                    break;
                case ConsoleKey.Add:
                    break;
                case ConsoleKey.Applications:
                    break;
                case ConsoleKey.Attention:
                    break;
                case ConsoleKey.B:
                    break;
                case ConsoleKey.Backspace:
                    break;
                case ConsoleKey.BrowserBack:
                    break;
                case ConsoleKey.BrowserFavorites:
                    break;
                case ConsoleKey.BrowserForward:
                    break;
                case ConsoleKey.BrowserHome:
                    break;
                case ConsoleKey.BrowserRefresh:
                    break;
                case ConsoleKey.BrowserSearch:
                    break;
                case ConsoleKey.BrowserStop:
                    break;
                case ConsoleKey.C:
                    break;
                case ConsoleKey.Clear:
                    break;
                case ConsoleKey.CrSel:
                    break;
                case ConsoleKey.D:
                    break;
                case ConsoleKey.D0:
                    break;
                case ConsoleKey.D1:
                    break;
                case ConsoleKey.D2:
                    break;
                case ConsoleKey.D3:
                    break;
                case ConsoleKey.D4:
                    break;
                case ConsoleKey.D5:
                    break;
                case ConsoleKey.D6:
                    break;
                case ConsoleKey.D7:
                    break;
                case ConsoleKey.D8:
                    break;
                case ConsoleKey.D9:
                    break;
                case ConsoleKey.Decimal:
                    break;
                case ConsoleKey.Delete:
                    break;
                case ConsoleKey.Divide:
                    break;
                case ConsoleKey.DownArrow:
                    break;
                case ConsoleKey.E:
                    break;
                case ConsoleKey.End:
                    break;
                case ConsoleKey.Enter:
                    break;
                case ConsoleKey.EraseEndOfFile:
                    break;
                case ConsoleKey.Escape:
                    break;
                case ConsoleKey.Execute:
                    break;
                case ConsoleKey.ExSel:
                    break;
                case ConsoleKey.F:
                    break;
                case ConsoleKey.F1:
                    break;
                case ConsoleKey.F10:
                    break;
                case ConsoleKey.F11:
                    break;
                case ConsoleKey.F12:
                    break;
                case ConsoleKey.F13:
                    break;
                case ConsoleKey.F14:
                    break;
                case ConsoleKey.F15:
                    break;
                case ConsoleKey.F16:
                    break;
                case ConsoleKey.F17:
                    break;
                case ConsoleKey.F18:
                    break;
                case ConsoleKey.F19:
                    break;
                case ConsoleKey.F2:
                    break;
                case ConsoleKey.F20:
                    break;
                case ConsoleKey.F21:
                    break;
                case ConsoleKey.F22:
                    break;
                case ConsoleKey.F23:
                    break;
                case ConsoleKey.F24:
                    break;
                case ConsoleKey.F3:
                    break;
                case ConsoleKey.F4:
                    break;
                case ConsoleKey.F5:
                    break;
                case ConsoleKey.F6:
                    break;
                case ConsoleKey.F7:
                    break;
                case ConsoleKey.F8:
                    break;
                case ConsoleKey.F9:
                    break;
                case ConsoleKey.G:
                    break;
                case ConsoleKey.H:
                    break;
                case ConsoleKey.Help:
                    break;
                case ConsoleKey.Home:
                    break;
                case ConsoleKey.I:
                    break;
                case ConsoleKey.Insert:
                    break;
                case ConsoleKey.J:
                    break;
                case ConsoleKey.K:
                    break;
                case ConsoleKey.L:
                    break;
                case ConsoleKey.LaunchApp1:
                    break;
                case ConsoleKey.LaunchApp2:
                    break;
                case ConsoleKey.LaunchMail:
                    break;
                case ConsoleKey.LaunchMediaSelect:
                    break;
                case ConsoleKey.LeftArrow:
                    break;
                case ConsoleKey.LeftWindows:
                    break;
                case ConsoleKey.M:
                    break;
                case ConsoleKey.MediaNext:
                    break;
                case ConsoleKey.MediaPlay:
                    break;
                case ConsoleKey.MediaPrevious:
                    break;
                case ConsoleKey.MediaStop:
                    break;
                case ConsoleKey.Multiply:
                    break;
                case ConsoleKey.N:
                    break;
                case ConsoleKey.NoName:
                    break;
                case ConsoleKey.NumPad0:
                    break;
                case ConsoleKey.NumPad1:
                    break;
                case ConsoleKey.NumPad2:
                    break;
                case ConsoleKey.NumPad3:
                    break;
                case ConsoleKey.NumPad4:
                    break;
                case ConsoleKey.NumPad5:
                    break;
                case ConsoleKey.NumPad6:
                    break;
                case ConsoleKey.NumPad7:
                    break;
                case ConsoleKey.NumPad8:
                    break;
                case ConsoleKey.NumPad9:
                    break;
                case ConsoleKey.O:
                    break;
                case ConsoleKey.Oem1:
                    break;
                case ConsoleKey.Oem102:
                    break;
                case ConsoleKey.Oem2:
                    break;
                case ConsoleKey.Oem3:
                    break;
                case ConsoleKey.Oem4:
                    break;
                case ConsoleKey.Oem5:
                    break;
                case ConsoleKey.Oem6:
                    break;
                case ConsoleKey.Oem7:
                    break;
                case ConsoleKey.Oem8:
                    break;
                case ConsoleKey.OemClear:
                    break;
                case ConsoleKey.OemComma:
                    break;
                case ConsoleKey.OemMinus:
                    break;
                case ConsoleKey.OemPeriod:
                    break;
                case ConsoleKey.OemPlus:
                    break;
                case ConsoleKey.P:
                    break;
                case ConsoleKey.Pa1:
                    break;
                case ConsoleKey.Packet:
                    break;
                case ConsoleKey.PageDown:
                    break;
                case ConsoleKey.PageUp:
                    break;
                case ConsoleKey.Pause:
                    break;
                case ConsoleKey.Play:
                    break;
                case ConsoleKey.Print:
                    break;
                case ConsoleKey.PrintScreen:
                    break;
                case ConsoleKey.Process:
                    break;
                case ConsoleKey.Q:
                    break;
                case ConsoleKey.R:
                    break;
                case ConsoleKey.RightArrow:
                    break;
                case ConsoleKey.RightWindows:
                    break;
                case ConsoleKey.S:
                    break;
                case ConsoleKey.Select:
                    break;
                case ConsoleKey.Separator:
                    break;
                case ConsoleKey.Sleep:
                    break;
                case ConsoleKey.Spacebar:
                    break;
                case ConsoleKey.Subtract:
                    break;
                case ConsoleKey.T:
                    break;
                case ConsoleKey.Tab:
                    break;
                case ConsoleKey.U:
                    break;
                case ConsoleKey.UpArrow:
                    break;
                case ConsoleKey.V:
                    break;
                case ConsoleKey.VolumeDown:
                    break;
                case ConsoleKey.VolumeMute:
                    break;
                case ConsoleKey.VolumeUp:
                    break;
                case ConsoleKey.W:
                    break;
                case ConsoleKey.X:
                    break;
                case ConsoleKey.Y:
                    break;
                case ConsoleKey.Z:
                    break;
                case ConsoleKey.Zoom:
                    break;
                default:
                    break;
            }
        }
    }
}
