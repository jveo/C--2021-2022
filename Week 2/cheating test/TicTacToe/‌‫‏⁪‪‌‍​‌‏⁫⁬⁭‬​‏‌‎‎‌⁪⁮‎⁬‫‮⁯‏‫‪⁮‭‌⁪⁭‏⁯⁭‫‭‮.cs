// Decompiled with JetBrains decompiler
// Type: ‌‫‏⁪‪‌‍​‌‏⁫⁬⁭‬​‏‌‎‎‌⁪⁮‎⁬‫‮⁯‏‫‪⁮‭‌⁪⁭‏⁯⁭‫‭‮
// Assembly: TicTacToe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9D9D4A6E-BB82-4124-BCB7-CCCD5CE14282
// Assembly location: C:\Users\jesse\Desktop\school2021-2022\C#\Week 3\TicTacToe\TicTacToe.exe

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

internal class \u200C‫‏⁪‪‌‍​‌‏⁫⁬⁭‬​‏‌‎‎‌⁪⁮‎⁬‫‮⁯‏‫‪⁮‭‌⁪⁭‏⁯⁭‫‭‮
{
  private \u200F​⁮‍‪‭‫⁫‬⁮‫‪⁫‌‍‎‬⁪‎‭‬‭⁪‫⁪‏⁪​‍⁯‌‬‬‎⁯‬‭‮‌⁭‮[] \u200E​‮‎‌‏‫‎‏⁯‬‮‌‪‮‌‮‏⁭‍⁮⁫‬‭‎⁭‮​‫⁯‭‍⁪​‍⁬‪⁭⁪‍‮;
  private \u206A‮⁬‎‏⁪‭‏‭⁭‪⁮⁯‮‍‍‌‍​​‏‫⁬‎‮⁫‫‎‮⁫‭​‎‏⁬‬⁫‪‫‮ \u202A‪‭⁭‏⁪‍⁮‎⁬⁫‫⁪‭‪⁪⁭‌‬⁪⁬‮⁬‬‪‏⁭⁯​‭⁪‪‏⁯⁮⁮⁬⁮‪⁯‮;
  private int[] \u200D⁬‍‪‌‮‎‍⁭‎⁮⁭⁯‭⁬⁫‮⁪‮⁪⁫‎‫⁯⁫⁪‭⁪‎‭‫‫‍​‍‮‫⁭‫‮‮;

  private \u200F​⁮‍‪‭‫⁫‬⁮‫‪⁫‌‍‎‬⁪‎‭‬‭⁪‫⁪‏⁪​‍⁯‌‬‬‎⁯‬‭‮‌⁭‮ \u206B‌⁯⁮⁯‌‮⁬‬‍⁯⁯⁭‏⁬‏‌⁫⁪⁮⁯⁬⁪‍‭⁭‎‪⁪⁫‏‬‫​‍​‮‎‭⁮‮ { get; set; }

  public \u200C‫‏⁪‪‌‍​‌‏⁫⁬⁭‬​‏‌‎‎‌⁪⁮‎⁬‫‮⁯‏‫‪⁮‭‌⁪⁭‏⁯⁭‫‭‮()
  {
    int[] numArray = new int[8];
    // ISSUE: field reference
    \u200C‫‏⁪‪‌‍​‌‏⁫⁬⁭‬​‏‌‎‎‌⁪⁮‎⁬‫‮⁯‏‫‪⁮‭‌⁪⁭‏⁯⁭‫‭‮.\u202D‏⁬‫⁯⁬‌⁫‫‌⁪‫⁮⁯​‏⁪‏‬‭⁯⁯⁯⁪⁪‌‏​‎‭⁪‭⁪⁮⁯⁬⁪‭‫⁮‮((Array) numArray, __fieldref (\u200C‪‌‫‍‭‭⁬‬‬⁪‌‭‍‫‫⁯⁮⁮‭⁬⁯⁭⁫‍⁮⁪‫⁫‌‌‭‫‪‭‌‬⁪‌‌‮.F147385656CD52790F59E6FB8A88C5027575145E4A87809B341A722222823382));
    this.\u200D⁬‍‪‌‮‎‍⁭‎⁮⁭⁯‭⁬⁫‮⁪‮⁪⁫‎‫⁯⁫⁪‭⁪‎‭‫‫‍​‍‮‫⁭‫‮‮ = numArray;
    // ISSUE: explicit constructor call
    base.\u002Ector();
label_1:
    int num1 = 1271471027;
    string str1;
    while (true)
    {
      uint num2;
      switch ((num2 = (uint) (num1 ^ 1070891584)) % 9U)
      {
        case 0:
          num1 = (int) num2 * 2072642418 ^ 944194194;
          continue;
        case 1:
          goto label_3;
        case 2:
          num1 = (int) num2 * -1047153769 ^ -1941101540;
          continue;
        case 3:
          str1 = \u200C‫‏⁪‪‌‍​‌‏⁫⁬⁭‬​‏‌‎‎‌⁪⁮‎⁬‫‮⁯‏‫‪⁮‭‌⁪⁭‏⁯⁭‫‭‮.\u202E‏‏⁬‍⁫‪‭‎‬‍⁮‫​⁯‪‎‫‏​​‌‫‭‬⁭⁬‮⁪‎‏‮‬⁭‬‍‏⁬⁭⁯‮();
          \u200C‫‏⁪‪‌‍​‌‏⁫⁬⁭‬​‏‌‎‎‌⁪⁮‎⁬‫‮⁯‏‫‪⁮‭‌⁪⁭‏⁯⁭‫‭‮.\u206F⁯⁮‎‫‎⁭‫⁭‍‫⁬​​‪⁪⁮‮⁮⁯​⁯‫‌‏⁬‫⁫⁫⁮⁮‬⁪‍‎⁪‎⁬‪⁭‮(\u003CModule\u003E.\u206D⁪‪‭‫‮⁬‫‎‭‎‍⁭​⁪‫‫‮‌⁬⁭‮​‭⁫⁫⁭⁭⁭⁯​‍‫‮‏‌⁬‪⁯‫‮<string>(3798785729U));
          num1 = (int) num2 * -1791186828 ^ -1413715457;
          continue;
        case 4:
          num1 = (int) num2 * -1221879840 ^ -675739174;
          continue;
        case 5:
          num1 = (int) num2 * -229864021 ^ 1418974630;
          continue;
        case 6:
          goto label_1;
        case 7:
          string str2 = \u200C‫‏⁪‪‌‍​‌‏⁫⁬⁭‬​‏‌‎‎‌⁪⁮‎⁬‫‮⁯‏‫‪⁮‭‌⁪⁭‏⁯⁭‫‭‮.\u202E‏‏⁬‍⁫‪‭‎‬‍⁮‫​⁯‪‎‫‏​​‌‫‭‬⁭⁬‮⁪‎‏‮‬⁭‬‍‏⁬⁭⁯‮();
          this.\u200E​‮‎‌‏‫‎‏⁯‬‮‌‪‮‌‮‏⁭‍⁮⁫‬‭‎⁭‮​‫⁯‭‍⁪​‍⁬‪⁭⁪‍‮ = new \u200F​⁮‍‪‭‫⁫‬⁮‫‪⁫‌‍‎‬⁪‎‭‬‭⁪‫⁪‏⁪​‍⁯‌‬‬‎⁯‬‭‮‌⁭‮[2]
          {
            new \u200F​⁮‍‪‭‫⁫‬⁮‫‪⁫‌‍‎‬⁪‎‭‬‭⁪‫⁪‏⁪​‍⁯‌‬‬‎⁯‬‭‮‌⁭‮(str1, 'X'),
            new \u200F​⁮‍‪‭‫⁫‬⁮‫‪⁫‌‍‎‬⁪‎‭‬‭⁪‫⁪‏⁪​‍⁯‌‬‬‎⁯‬‭‮‌⁭‮(str2, 'O')
          };
          this.\u202A‪‭⁭‏⁪‍⁮‎⁬⁫‫⁪‭‪⁪⁭‌‬⁪⁬‮⁬‬‪‏⁭⁯​‭⁪‪‏⁯⁮⁮⁬⁮‪⁯‮ = new \u206A‮⁬‎‏⁪‭‏‭⁭‪⁮⁯‮‍‍‌‍​​‏‫⁬‎‮⁫‫‎‮⁫‭​‎‏⁬‬⁫‪‫‮();
          this.\u206B‌⁯⁮⁯‌‮⁬‬‍⁯⁯⁭‏⁬‏‌⁫⁪⁮⁯⁬⁪‍‭⁭‎‪⁪⁫‏‬‫​‍​‮‎‭⁮‮ = this.\u200E​‮‎‌‏‫‎‏⁯‬‮‌‪‮‌‮‏⁭‍⁮⁫‬‭‎⁭‮​‫⁯‭‍⁪​‍⁬‪⁭⁪‍‮[0];
          num1 = (int) num2 * 331510901 ^ -1411213644;
          continue;
        case 8:
          \u200C‫‏⁪‪‌‍​‌‏⁫⁬⁭‬​‏‌‎‎‌⁪⁮‎⁬‫‮⁯‏‫‪⁮‭‌⁪⁭‏⁯⁭‫‭‮.\u206F⁯⁮‎‫‎⁭‫⁭‍‫⁬​​‪⁪⁮‮⁮⁯​⁯‫‌‏⁬‫⁫⁫⁮⁮‬⁪‍‎⁪‎⁬‪⁭‮(\u003CModule\u003E.\u206D⁪‪‭‫‮⁬‫‎‭‎‍⁭​⁪‫‫‮‌⁬⁭‮​‭⁫⁫⁭⁭⁭⁯​‍‫‮‏‌⁬‪⁯‫‮<string>(3147402751U));
          num1 = (int) num2 * -1389889249 ^ 1602319609;
          continue;
        default:
          goto label_11;
      }
    }
label_3:
    return;
label_11:;
  }

  public void \u206E‎⁭​‏‬⁬⁪‫​​⁯‬‫⁯⁯‎‏​⁫⁬‭​⁯⁮‪‌⁮⁭⁭‭‪‮‬⁯⁫‭‍‬‏‮()
  {
label_1:
    int num1 = -210136909;
    int num2;
    bool flag1;
    bool flag2;
    while (true)
    {
      uint num3;
      switch ((num3 = (uint) (num1 ^ -586104420)) % 22U)
      {
        case 0:
          num1 = (int) num3 * -1290800942 ^ -1346172088;
          continue;
        case 1:
          num1 = (int) num3 * 1547050904 ^ -227675639;
          continue;
        case 2:
          this.\u206C⁮‪​‭​⁫‎⁬‏​​⁪​​⁮⁯⁭‌‎⁪⁪‫‏‏⁯⁯⁪‫‍⁮⁫‪‪​‌​‌⁫‏‮();
          num1 = (int) num3 * 866988820 ^ 688034955;
          continue;
        case 3:
          num1 = (int) num3 * -1605836320 ^ 366988747;
          continue;
        case 4:
          ++num2;
          num1 = (int) num3 * 1503625102 ^ -1636653456;
          continue;
        case 5:
          this.\u202A‪‭⁭‏⁪‍⁮‎⁬⁫‫⁪‭‪⁪⁭‌‬⁪⁬‮⁬‬‪‏⁭⁯​‭⁪‪‏⁯⁮⁮⁬⁮‪⁯‮.\u202D‮‫‍‌‫‮‭‎⁭‍⁬⁫‫‌⁯‎‬​⁫⁯⁮‍‫⁫⁬‪⁭⁬‫⁪‌⁫‍‭‫‪‬⁮‏‮(this.\u200E​‮‎‌‏‫‎‏⁯‬‮‌‪‮‌‮‏⁭‍⁮⁫‬‭‎⁭‮​‫⁯‭‍⁪​‍⁬‪⁭⁪‍‮);
          num1 = (int) num3 * -145210804 ^ -1590249148;
          continue;
        case 6:
          flag1 = num2 <= 9;
          num1 = -2056779477;
          continue;
        case 7:
          num1 = (int) num3 * -68397401 ^ -534080835;
          continue;
        case 8:
          goto label_3;
        case 9:
          num1 = (int) num3 * -1368608764 ^ -451559794;
          continue;
        case 10:
          \u200C‫‏⁪‪‌‍​‌‏⁫⁬⁭‬​‏‌‎‎‌⁪⁮‎⁬‫‮⁯‏‫‪⁮‭‌⁪⁭‏⁯⁭‫‭‮.\u202C‫‎⁬⁮⁬‍‮​‪‎⁭‎‍‭‎‫‌⁫‏‭‍⁪‌‭‎‫‌‮⁭‫⁮⁮⁮‭‏‌​‍‌‮();
          num1 = -653213281;
          continue;
        case 11:
          this.\u202A‪‭⁭‏⁪‍⁮‎⁬⁫‫⁪‭‪⁪⁭‌‬⁪⁬‮⁬‬‪‏⁭⁯​‭⁪‪‏⁯⁮⁮⁬⁮‪⁯‮.\u202D‮‫‍‌‫‮‭‎⁭‍⁬⁫‫‌⁯‎‬​⁫⁯⁮‍‫⁫⁬‪⁭⁬‫⁪‌⁫‍‭‫‪‬⁮‏‮(this.\u200E​‮‎‌‏‫‎‏⁯‬‮‌‪‮‌‮‏⁭‍⁮⁫‬‭‎⁭‮​‫⁯‭‍⁪​‍⁬‪⁭⁪‍‮);
          num1 = (int) num3 * 932037371 ^ 1965243605;
          continue;
        case 12:
          this.\u202D‌‪⁯⁮‭‎‍‬‬‭⁮‎⁪‎‬‮‪‏‪‮⁬‌‪⁭‫⁭⁪​⁭‬⁫⁭⁪‌⁯⁬‮‬‌‮(num2);
          num1 = (int) num3 * -183645181 ^ 2092334744;
          continue;
        case 13:
          num2 = 1;
          num1 = (int) num3 * -1389475796 ^ 1604132620;
          continue;
        case 14:
          int num4 = flag2 ? -1857434041 : (num4 = -988292509);
          num1 = num4 ^ (int) num3 * -1682284237;
          continue;
        case 15:
          int num5 = !flag1 ? -1071137774 : (num5 = -1841843919);
          num1 = num5 ^ (int) num3 * -1670979236;
          continue;
        case 16:
          goto label_1;
        case 17:
          num1 = (int) num3 * -1246205100 ^ 836876624;
          continue;
        case 18:
          num1 = (int) num3 * -1006801038 ^ 1769025901;
          continue;
        case 19:
          \u200C‫‏⁪‪‌‍​‌‏⁫⁬⁭‬​‏‌‎‎‌⁪⁮‎⁬‫‮⁯‏‫‪⁮‭‌⁪⁭‏⁯⁭‫‭‮.\u202C‫‎⁬⁮⁬‍‮​‪‎⁭‎‍‭‎‫‌⁫‏‭‍⁪‌‭‎‫‌‮⁭‫⁮⁮⁮‭‏‌​‍‌‮();
          num1 = -692103307;
          continue;
        case 20:
          flag2 = this.\u206E⁭‪‮‪⁪​⁫‎⁬⁫⁯‎‫⁯‎⁯⁯⁯‪⁭‏⁫​‏⁭‫‫⁮⁬‮‍⁭‪⁬‌‮⁮⁫‎‮();
          num1 = (int) num3 * 565394303 ^ -306670516;
          continue;
        case 21:
          this.\u206B‌⁯⁮⁯‌‮⁬‬‍⁯⁯⁭‏⁬‏‌⁫⁪⁮⁯⁬⁪‍‭⁭‎‪⁪⁫‏‬‫​‍​‮‎‭⁮‮ = this.\u206B‌⁯⁮⁯‌‮⁬‬‍⁯⁯⁭‏⁬‏‌⁫⁪⁮⁯⁬⁪‍‭⁭‎‪⁪⁫‏‬‫​‍​‮‎‭⁮‮ == this.\u200E​‮‎‌‏‫‎‏⁯‬‮‌‪‮‌‮‏⁭‍⁮⁫‬‭‎⁭‮​‫⁯‭‍⁪​‍⁬‪⁭⁪‍‮[0] ? this.\u200E​‮‎‌‏‫‎‏⁯‬‮‌‪‮‌‮‏⁭‍⁮⁫‬‭‎⁭‮​‫⁯‭‍⁪​‍⁬‪⁭⁪‍‮[1] : this.\u200E​‮‎‌‏‫‎‏⁯‬‮‌‪‮‌‮‏⁭‍⁮⁫‬‭‎⁭‮​‫⁯‭‍⁪​‍⁬‪⁭⁪‍‮[0];
          num1 = -327748878;
          continue;
        default:
          goto label_24;
      }
    }
label_3:
    return;
label_24:;
  }

  private void \u206C⁮‪​‭​⁫‎⁬‏​​⁪​​⁮⁯⁭‌‎⁪⁪‫‏‏⁯⁯⁪‫‍⁮⁫‪‪​‌​‌⁫‏‮()
  {
label_1:
    int num1 = 1285323407;
    string str;
    bool flag;
    while (true)
    {
      uint num2;
      switch ((num2 = (uint) (num1 ^ 1105787440)) % 8U)
      {
        case 0:
          num1 = (int) num2 * -1810957945 ^ 1510472924;
          continue;
        case 1:
          \u200C‫‏⁪‪‌‍​‌‏⁫⁬⁭‬​‏‌‎‎‌⁪⁮‎⁬‫‮⁯‏‫‪⁮‭‌⁪⁭‏⁯⁭‫‭‮.\u206F⁯⁮‎‫‎⁭‫⁭‍‫⁬​​‪⁪⁮‮⁮⁯​⁯‫‌‏⁬‫⁫⁫⁮⁮‬⁪‍‎⁪‎⁬‪⁭‮(\u200C‫‏⁪‪‌‍​‌‏⁫⁬⁭‬​‏‌‎‎‌⁪⁮‎⁬‫‮⁯‏‫‪⁮‭‌⁪⁭‏⁯⁭‫‭‮.\u202C⁫‭⁭‏‭‫⁪⁫‭‭⁬‬⁫‭‍‮⁭⁪‭⁬​‮‭⁫‪⁫‫​⁭⁯​‍‌‫⁪⁯⁮⁬‮‮(\u003CModule\u003E.\u200E‫‪⁭‌⁮⁫‪⁫‎⁯⁬​‌‍‎‮‮‬‭​⁬‫‌⁪‬‭⁮‎⁫⁭‪‮‬‏‍‪‬‬‪‮<string>(2927761039U), (object) this.\u206B‌⁯⁮⁯‌‮⁬‬‍⁯⁯⁭‏⁬‏‌⁫⁪⁮⁯⁬⁪‍‭⁭‎‪⁪⁫‏‬‫​‍​‮‎‭⁮‮.\u202B⁫​⁮⁭‫⁫​‎​​⁭⁮‫‪‍⁯‎‏‮​‪⁫‬‫⁯⁭‌‭⁯⁯⁬‭‭‬⁪⁮⁫⁪‫‮, (object) this.\u206B‌⁯⁮⁯‌‮⁬‬‍⁯⁯⁭‏⁬‏‌⁫⁪⁮⁯⁬⁪‍‭⁭‎‪⁪⁫‏‬‫​‍​‮‎‭⁮‮.\u202D⁪⁯‍‌‬⁬​‍‌⁫‮‫‏⁪⁪‏‭⁮⁯​⁮⁯‏‫⁯‏‭​‪⁫​‫​⁮‍‮⁯‌‍‮));
          num1 = (int) num2 * -1136554997 ^ -1555992499;
          continue;
        case 2:
          goto label_3;
        case 3:
          flag = this.\u206F⁯‬‮‎‍‎⁯⁭⁫‬‏‍‬​⁪‎⁭‌‍‍‮⁪‌⁯‮⁮⁯‭‪‪⁬⁭‪‬‮‪‎‮‏‮(str);
          num1 = (int) num2 * -1590477396 ^ 1410896420;
          continue;
        case 4:
          int num3 = flag ? 1212686882 : (num3 = 1068986903);
          num1 = num3 ^ (int) num2 * 455984378;
          continue;
        case 5:
          goto label_1;
        case 6:
          str = \u200C‫‏⁪‪‌‍​‌‏⁫⁬⁭‬​‏‌‎‎‌⁪⁮‎⁬‫‮⁯‏‫‪⁮‭‌⁪⁭‏⁯⁭‫‭‮.\u202E‏‏⁬‍⁫‪‭‎‬‍⁮‫​⁯‪‎‫‏​​‌‫‭‬⁭⁬‮⁪‎‏‮‬⁭‬‍‏⁬⁭⁯‮();
          num1 = (int) num2 * -2041412228 ^ -1448984765;
          continue;
        case 7:
          num1 = 981249145;
          continue;
        default:
          goto label_10;
      }
    }
label_3:
    return;
label_10:;
  }

  private bool \u206F⁯‬‮‎‍‎⁯⁭⁫‬‏‍‬​⁪‎⁭‌‍‍‮⁪‌⁯‮⁮⁯‭‪‪⁬⁭‪‬‮‪‎‮‏‮(string _param1)
  {
    bool flag1 = false;
label_1:
    int num1 = -2141739328;
    uint num2;
    \u200F​⁮‍‪‭‫⁫‬⁮‫‪⁫‌‍‎‬⁪‎‭‬‭⁪‫⁪‏⁪​‍⁯‌‬‬‎⁯‬‭‮‌⁭‮[] objArray;
    string str;
    bool flag2;
    int index;
    \u200F​⁮‍‪‭‫⁫‬⁮‫‪⁫‌‍‎‬⁪‎‭‬‭⁪‫⁪‏⁪​‍⁯‌‬‬‎⁯‬‭‮‌⁭‮ obj;
    int num3;
    bool flag3;
    while (true)
    {
      uint num4;
      switch ((num4 = (uint) (num1 ^ -31257181)) % 65U)
      {
        case 0:
          int num5;
          num1 = num5 = num2 == 906799682U ? -2039353267 : (num5 = -1980539235);
          continue;
        case 1:
          num1 = (int) num4 * -1989688207 ^ 1291277870;
          continue;
        case 2:
          int num6;
          num1 = num6 = \u200C‫‏⁪‪‌‍​‌‏⁫⁬⁭‬​‏‌‎‎‌⁪⁮‎⁬‫‮⁯‏‫‪⁮‭‌⁪⁭‏⁯⁭‫‭‮.\u206D‌⁭‫‭‬‮⁫⁭‎⁫‫‎⁯‮⁪⁯⁪‪⁪⁬‭‌⁪⁬‫⁮⁮‏‭⁯‎⁪‭‪‍‍‭⁬‬‮(str, \u003CModule\u003E.\u200F‎‪‪‪⁭⁯‮⁫⁪‫‪‍‫⁬⁮‪⁬⁯⁯‎‍⁬‎‫‪‮⁮‫‎‌⁪‮⁯‭‏⁭‬⁭‭‮<string>(2682161668U)) ? -959301490 : (num6 = -48900783);
          continue;
        case 3:
          int num7 = num2 != 873244444U ? -1672434926 : (num7 = -868828294);
          num1 = num7 ^ (int) num4 * 1232586890;
          continue;
        case 4:
          num1 = (int) num4 * 1634018844 ^ 1664626739;
          continue;
        case 5:
          int num8;
          num1 = num8 = \u200C‫‏⁪‪‌‍​‌‏⁫⁬⁭‬​‏‌‎‎‌⁪⁮‎⁬‫‮⁯‏‫‪⁮‭‌⁪⁭‏⁯⁭‫‭‮.\u206D‌⁭‫‭‬‮⁫⁭‎⁫‫‎⁯‮⁪⁯⁪‪⁪⁬‭‌⁪⁬‫⁮⁮‏‭⁯‎⁪‭‪‍‍‭⁬‬‮(str, \u003CModule\u003E.\u200E⁮‎⁮⁫‏‭⁯​⁮‪‬‬⁬⁬‪​⁯⁭‎‌‭⁮‮⁮​‬‌⁯⁫⁭⁮⁯‬‫‪⁬⁯‎⁮‮<string>(712983029U)) ? -959301490 : (num8 = -1198682665);
          continue;
        case 6:
          num1 = (int) num4 * 1235851863 ^ 1657772040;
          continue;
        case 7:
          int num9;
          num1 = num9 = !\u200C‫‏⁪‪‌‍​‌‏⁫⁬⁭‬​‏‌‎‎‌⁪⁮‎⁬‫‮⁯‏‫‪⁮‭‌⁪⁭‏⁯⁭‫‭‮.\u206D‌⁭‫‭‬‮⁫⁭‎⁫‫‎⁯‮⁪⁯⁪‪⁪⁬‭‌⁪⁬‫⁮⁮‏‭⁯‎⁪‭‪‍‍‭⁬‬‮(str, \u003CModule\u003E.\u200F‎‪‪‪⁭⁯‮⁫⁪‫‪‍‫⁬⁮‪⁬⁯⁯‎‍⁬‎‫‪‮⁮‫‎‌⁪‮⁯‭‏⁭‬⁭‭‮<string>(3046941442U)) ? -1912042476 : (num9 = -959301490);
          continue;
        case 8:
          int num10;
          num1 = num10 = !\u200C‫‏⁪‪‌‍​‌‏⁫⁬⁭‬​‏‌‎‎‌⁪⁮‎⁬‫‮⁯‏‫‪⁮‭‌⁪⁭‏⁯⁭‫‭‮.\u206D‌⁭‫‭‬‮⁫⁭‎⁫‫‎⁯‮⁪⁯⁪‪⁪⁬‭‌⁪⁬‫⁮⁮‏‭⁯‎⁪‭‪‍‍‭⁬‬‮(str, \u003CModule\u003E.\u200F‎‪‪‪⁭⁯‮⁫⁪‫‪‍‫⁬⁮‪⁬⁯⁯‎‍⁬‎‫‪‮⁮‫‎‌⁪‮⁯‭‏⁭‬⁭‭‮<string>(3944036112U)) ? -1225921012 : (num10 = -959301490);
          continue;
        case 9:
          int num11;
          num1 = num11 = \u200C‫‏⁪‪‌‍​‌‏⁫⁬⁭‬​‏‌‎‎‌⁪⁮‎⁬‫‮⁯‏‫‪⁮‭‌⁪⁭‏⁯⁭‫‭‮.\u206D‌⁭‫‭‬‮⁫⁭‎⁫‫‎⁯‮⁪⁯⁪‪⁪⁬‭‌⁪⁬‫⁮⁮‏‭⁯‎⁪‭‪‍‍‭⁬‬‮(str, \u003CModule\u003E.\u200F‎‪‪‪⁭⁯‮⁫⁪‫‪‍‫⁬⁮‪⁬⁯⁯‎‍⁬‎‫‪‮⁮‫‎‌⁪‮⁯‭‏⁭‬⁭‭‮<string>(3677878664U)) ? -959301490 : (num11 = -9344952);
          continue;
        case 10:
          int num12 = flag3 ? -34540158 : (num12 = -1715140906);
          num1 = num12 ^ (int) num4 * 1150497356;
          continue;
        case 11:
          \u200C‫‏⁪‪‌‍​‌‏⁫⁬⁭‬​‏‌‎‎‌⁪⁮‎⁬‫‮⁯‏‫‪⁮‭‌⁪⁭‏⁯⁭‫‭‮.\u202D‬‍‫⁫‭‌‬‭⁭‫‏⁯‏‏⁭‬⁭‫⁪‏‫‌⁮‍‏​‮‬⁭‭‫⁮​⁬⁫‌⁯‭⁮‮(\u003CModule\u003E.\u200E‫‪⁭‌⁮⁫‪⁫‎⁯⁬​‌‍‎‮‮‬‭​⁬‫‌⁪‬‭⁮‎⁫⁭‪‮‬‏‍‪‬‬‪‮<string>(1983371015U));
          num1 = (int) num4 * -1905152994 ^ 1791398697;
          continue;
        case 12:
          num1 = (int) num4 * -1793606887 ^ 1769805873;
          continue;
        case 13:
          flag3 = (obj.\u200B‎⁯‭‬‮‎‪‭‭‬⁮‪⁯⁫⁫‏​⁫⁪‭‎‏‍‫‏⁮⁫‭‪‎⁪​⁪⁮‌‭⁯⁫⁭‮ & num3) == num3;
          num1 = (int) num4 * -154687662 ^ -433388351;
          continue;
        case 15:
          num1 = (int) num4 * -636099660 ^ 1811907034;
          continue;
        case 16:
          num1 = (int) num4 * -1963073326 ^ -1550215843;
          continue;
        case 17:
          num1 = (int) num4 * 637683588 ^ 1667157368;
          continue;
        case 18:
          num1 = (int) num4 * -541609852 ^ -470834074;
          continue;
        case 19:
          num1 = (int) num4 * -303273642 ^ -253212815;
          continue;
        case 20:
          int num13;
          num1 = num13 = !\u200C‫‏⁪‪‌‍​‌‏⁫⁬⁭‬​‏‌‎‎‌⁪⁮‎⁬‫‮⁯‏‫‪⁮‭‌⁪⁭‏⁯⁭‫‭‮.\u206D‌⁭‫‭‬‮⁫⁭‎⁫‫‎⁯‮⁪⁯⁪‪⁪⁬‭‌⁪⁬‫⁮⁮‏‭⁯‎⁪‭‪‍‍‭⁬‬‮(str, \u003CModule\u003E.\u200F‎‪‪‪⁭⁯‮⁫⁪‫‪‍‫⁬⁮‪⁬⁯⁯‎‍⁬‎‫‪‮⁮‫‎‌⁪‮⁯‭‏⁭‬⁭‭‮<string>(2051224446U)) ? -1651430851 : (num13 = -959301490);
          continue;
        case 21:
          objArray = this.\u200E​‮‎‌‏‫‎‏⁯‬‮‌‪‮‌‮‏⁭‍⁮⁫‬‭‎⁭‮​‫⁯‭‍⁪​‍⁬‪⁭⁪‍‮;
          num1 = (int) num4 * 2110328960 ^ -1840347756;
          continue;
        case 22:
          num1 = (int) num4 * -518508273 ^ 504225881;
          continue;
        case 23:
          int num14;
          num1 = num14 = num2 == 1024243015U ? -72673061 : (num14 = -1771068697);
          continue;
        case 24:
          num1 = (int) num4 * -809549964 ^ -631793034;
          continue;
        case 25:
          int num15 = num2 > 822911587U ? 496088692 : (num15 = 2132302974);
          num1 = num15 ^ (int) num4 * 560630364;
          continue;
        case 26:
          flag2 = false;
          num1 = (int) num4 * 90958436 ^ -1760080074;
          continue;
        case 27:
          int num16 = num2 <= 856466825U ? 1765522664 : (num16 = 1056428465);
          num1 = num16 ^ (int) num4 * 963236750;
          continue;
        case 28:
          \u200C‫‏⁪‪‌‍​‌‏⁫⁬⁭‬​‏‌‎‎‌⁪⁮‎⁬‫‮⁯‏‫‪⁮‭‌⁪⁭‏⁯⁭‫‭‮.\u202D‬‍‫⁫‭‌‬‭⁭‫‏⁯‏‏⁭‬⁭‫⁪‏‫‌⁮‍‏​‮‬⁭‭‫⁮​⁬⁫‌⁯‭⁮‮(\u003CModule\u003E.\u200E​‎‏‪⁪‎​⁯‏‫⁭​‫⁭⁬​‮⁪‮​​⁫‬‭‏‏‫‬‏‫‮‍⁯‬⁪‎⁯⁯‮‮<string>(3906542196U));
          num1 = -1366090990;
          continue;
        case 29:
          this.\u206B‌⁯⁮⁯‌‮⁬‬‍⁯⁯⁭‏⁬‏‌⁫⁪⁮⁯⁬⁪‍‭⁭‎‪⁪⁫‏‬‫​‍​‮‎‭⁮‮.\u200B‎⁯‭‬‮‎‪‭‭‬⁮‪⁯⁫⁫‏​⁫⁪‭‎‏‍‫‏⁮⁫‭‪‎⁪​⁪⁮‌‭⁯⁫⁭‮ |= num3;
          num1 = (int) num4 * -303688190 ^ -1488742032;
          continue;
        case 30:
          num1 = (int) num4 * -1926914801 ^ 1964751011;
          continue;
        case 31:
          int num17;
          num1 = num17 = num2 == 822911587U ? -780360838 : (num17 = -890396949);
          continue;
        case 32:
          str = _param1;
          int num18 = str != null ? -1443489282 : (num18 = -2066401197);
          num1 = num18 ^ (int) num4 * -1384904097;
          continue;
        case 33:
          ++index;
          num1 = (int) num4 * 1719903940 ^ 757772818;
          continue;
        case 34:
          index = 0;
          num1 = (int) num4 * 1378004016 ^ 125757087;
          continue;
        case 35:
          num1 = (int) num4 * -835040564 ^ -1252504934;
          continue;
        case 36:
          flag2 = flag1;
          num1 = -108163152;
          continue;
        case 37:
          num1 = (int) num4 * 275459241 ^ -473180826;
          continue;
        case 38:
          num1 = (int) num4 * -1167806429 ^ 1451686306;
          continue;
        case 39:
          num1 = (int) num4 * -1954992492 ^ -670406094;
          continue;
        case 40:
          num3 = 1 << int.Parse(_param1) - 1;
          num1 = -122096656;
          continue;
        case 41:
          int num19;
          num1 = num19 = num2 == 1007465396U ? -1465094874 : (num19 = -793076499);
          continue;
        case 42:
          num1 = (int) num4 * 556236577 ^ -251168144;
          continue;
        case 43:
          int num20;
          num1 = num20 = \u200C‫‏⁪‪‌‍​‌‏⁫⁬⁭‬​‏‌‎‎‌⁪⁮‎⁬‫‮⁯‏‫‪⁮‭‌⁪⁭‏⁯⁭‫‭‮.\u206D‌⁭‫‭‬‮⁫⁭‎⁫‫‎⁯‮⁪⁯⁪‪⁪⁬‭‌⁪⁬‫⁮⁮‏‭⁯‎⁪‭‪‍‍‭⁬‬‮(str, \u003CModule\u003E.\u200F‎‪‪‪⁭⁯‮⁫⁪‫‪‍‫⁬⁮‪⁬⁯⁯‎‍⁬‎‫‪‮⁮‫‎‌⁪‮⁯‭‏⁭‬⁭‭‮<string>(2416004220U)) ? -959301490 : (num20 = -25314171);
          continue;
        case 44:
          num1 = (int) num4 * -1655136777 ^ 1282389557;
          continue;
        case 45:
          int num21;
          num1 = num21 = num2 <= 906799682U ? -449808637 : (num21 = -525279636);
          continue;
        case 46:
          goto label_1;
        case 47:
          // ISSUE: reference to a compiler-generated method
          num2 = \u200C‪‌‫‍‭‭⁬‬‬⁪‌‭‍‫‫⁯⁮⁮‭⁬⁯⁭⁫‍⁮⁪‫⁫‌‌‭‫‪‭‌‬⁪‌‌‮.\u206D⁮‮⁭⁫‌⁯⁫⁪‏‏‫‏⁫‬⁫⁯⁯⁭⁭​‏​​⁭​⁭‫‎⁮‮⁮⁭⁪‭‍‏⁪⁬‭‮(str);
          num1 = (int) num4 * 1529896744 ^ -114773259;
          continue;
        case 48:
          int num22;
          num1 = num22 = \u200C‫‏⁪‪‌‍​‌‏⁫⁬⁭‬​‏‌‎‎‌⁪⁮‎⁬‫‮⁯‏‫‪⁮‭‌⁪⁭‏⁯⁭‫‭‮.\u206D‌⁭‫‭‬‮⁫⁭‎⁫‫‎⁯‮⁪⁯⁪‪⁪⁬‭‌⁪⁬‫⁮⁮‏‭⁯‎⁪‭‪‍‍‭⁬‬‮(str, \u003CModule\u003E.\u200F‎‪‪‪⁭⁯‮⁫⁪‫‪‍‫⁬⁮‪⁬⁯⁯‎‍⁬‎‫‪‮⁮‫‎‌⁪‮⁯‭‏⁭‬⁭‭‮<string>(3313098890U)) ? -959301490 : (num22 = -1089311191);
          continue;
        case 49:
          int num23;
          num1 = num23 = num2 != 856466825U ? -1595025506 : (num23 = -1201857295);
          continue;
        case 50:
          num1 = (int) num4 * -1501040624 ^ 2103582926;
          continue;
        case 51:
          flag1 = true;
          num1 = (int) num4 * -63591142 ^ 1100335064;
          continue;
        case 52:
          obj = objArray[index];
          num1 = -1068894706;
          continue;
        case 53:
          num1 = (int) num4 * 2060887798 ^ 889120918;
          continue;
        case 54:
          num1 = (int) num4 * 1629198213 ^ -1346552496;
          continue;
        case 55:
          int num24;
          num1 = num24 = num2 != 923577301U ? -1292593109 : (num24 = -961343852);
          continue;
        case 56:
          num1 = -609129374;
          continue;
        case 57:
          num1 = (int) num4 * 73066197 ^ -1712932488;
          continue;
        case 58:
          num1 = (int) num4 * 1840714106 ^ 513361364;
          continue;
        case 59:
          int num25;
          num1 = num25 = index < objArray.Length ? -810260374 : (num25 = -827679269);
          continue;
        case 60:
          num1 = (int) num4 * -159319462 ^ 804679480;
          continue;
        case 61:
          num1 = (int) num4 * 1470414714 ^ -2007653214;
          continue;
        case 62:
          int num26;
          num1 = num26 = num2 != 839689206U ? -388201275 : (num26 = -1509574522);
          continue;
        case 63:
          int num27;
          num1 = num27 = !\u200C‫‏⁪‪‌‍​‌‏⁫⁬⁭‬​‏‌‎‎‌⁪⁮‎⁬‫‮⁯‏‫‪⁮‭‌⁪⁭‏⁯⁭‫‭‮.\u206D‌⁭‫‭‬‮⁫⁭‎⁫‫‎⁯‮⁪⁯⁪‪⁪⁬‭‌⁪⁬‫⁮⁮‏‭⁯‎⁪‭‪‍‍‭⁬‬‮(str, \u003CModule\u003E.\u200E⁮‎⁮⁫‏‭⁯​⁮‪‬‬⁬⁬‪​⁯⁭‎‌‭⁮‮⁮​‬‌⁯⁫⁭⁮⁯‬‫‪⁬⁯‎⁮‮<string>(1930545739U)) ? -1125857731 : (num27 = -959301490);
          continue;
        case 64:
          int num28 = num2 == 806133968U ? -611281737 : (num28 = -1367813320);
          num1 = num28 ^ (int) num4 * 487513668;
          continue;
        default:
          goto label_66;
      }
    }
label_66:
    return flag2;
  }

  private void \u202D‌‪⁯⁮‭‎‍‬‬‭⁮‎⁪‎‬‮‪‏‪‮⁬‌‪⁭‫⁭⁪​⁭‬⁫⁭⁪‌⁯⁬‮‬‌‮(int _param1)
  {
    if (_param1 <= 9)
      goto label_7;
label_1:
    int num1 = 720372419;
label_2:
    while (true)
    {
      uint num2;
      switch ((num2 = (uint) (num1 ^ 168706130)) % 8U)
      {
        case 0:
          goto label_7;
        case 1:
          \u200C‫‏⁪‪‌‍​‌‏⁫⁬⁭‬​‏‌‎‎‌⁪⁮‎⁬‫‮⁯‏‫‪⁮‭‌⁪⁭‏⁯⁭‫‭‮.\u202D‬‍‫⁫‭‌‬‭⁭‫‏⁯‏‏⁭‬⁭‫⁪‏‫‌⁮‍‏​‮‬⁭‭‫⁮​⁬⁫‌⁯‭⁮‮(\u003CModule\u003E.\u200E​‎‏‪⁪‎​⁯‏‫⁭​‫⁭⁬​‮⁪‮​​⁫‬‭‏‏‫‬‏‫‮‍⁯‬⁪‎⁯⁯‮‮<string>(1537796787U));
          num1 = (int) num2 * 1547992432 ^ 1677655249;
          continue;
        case 2:
          num1 = (int) num2 * 2069136892 ^ 741273663;
          continue;
        case 3:
          num1 = (int) num2 * -1931623299 ^ 1643735223;
          continue;
        case 4:
          goto label_1;
        case 5:
          num1 = (int) num2 * -863396878 ^ 1576405862;
          continue;
        case 6:
          goto label_3;
        case 7:
          \u200C‫‏⁪‪‌‍​‌‏⁫⁬⁭‬​‏‌‎‎‌⁪⁮‎⁬‫‮⁯‏‫‪⁮‭‌⁪⁭‏⁯⁭‫‭‮.\u202D‬‍‫⁫‭‌‬‭⁭‫‏⁯‏‏⁭‬⁭‫⁪‏‫‌⁮‍‏​‮‬⁭‭‫⁮​⁬⁫‌⁯‭⁮‮(\u200C‫‏⁪‪‌‍​‌‏⁫⁬⁭‬​‏‌‎‎‌⁪⁮‎⁬‫‮⁯‏‫‪⁮‭‌⁪⁭‏⁯⁭‫‭‮.\u200F‏‌⁫​​‮‭‌‏​‪‏‪‎‫‎⁬⁫​‪⁫‭‭‍‪‏‫‌‌‎‮​‫⁮⁮‪⁪‌⁬‮(\u003CModule\u003E.\u200E​‎‏‪⁪‎​⁯‏‫⁭​‫⁭⁬​‮⁪‮​​⁫‬‭‏‏‫‬‏‫‮‍⁯‬⁪‎⁯⁯‮‮<string>(337513209U), this.\u206B‌⁯⁮⁯‌‮⁬‬‍⁯⁯⁭‏⁬‏‌⁫⁪⁮⁯⁬⁪‍‭⁭‎‪⁪⁫‏‬‫​‍​‮‎‭⁮‮.\u202B⁫​⁮⁭‫⁫​‎​​⁭⁮‫‪‍⁯‎‏‮​‪⁫‬‫⁯⁭‌‭⁯⁯⁬‭‭‬⁪⁮⁫⁪‫‮, \u003CModule\u003E.\u200E‫‪⁭‌⁮⁫‪⁫‎⁯⁬​‌‍‎‮‮‬‭​⁬‫‌⁪‬‭⁮‎⁫⁭‪‮‬‏‍‪‬‬‪‮<string>(1335358527U)));
          num1 = (int) num2 * 468829130 ^ 2111188842;
          continue;
        default:
          goto label_10;
      }
    }
label_3:
    return;
label_10:
    return;
label_7:
    num1 = 1437943773;
    goto label_2;
  }

  private bool \u206E⁭‪‮‪⁪​⁫‎⁬⁫⁯‎‫⁯‎⁯⁯⁯‪⁭‏⁫​‏⁭‫‫⁮⁬‮‍⁭‪⁬‌‮⁮⁫‎‮()
  {
label_1:
    int num1 = -1713101523;
    int index;
    int[] numArray;
    bool flag;
    int num2;
    while (true)
    {
      uint num3;
      switch ((num3 = (uint) (num1 ^ -2739602)) % 15U)
      {
        case 0:
          goto label_1;
        case 1:
          num1 = -287654473;
          continue;
        case 2:
          num1 = (int) num3 * 637504241 ^ -670187248;
          continue;
        case 3:
          num1 = (int) num3 * -2098249687 ^ -349082801;
          continue;
        case 4:
          flag = true;
          num1 = (int) num3 * 736648553 ^ -785494923;
          continue;
        case 5:
          int num4 = (num2 & this.\u206B‌⁯⁮⁯‌‮⁬‬‍⁯⁯⁭‏⁬‏‌⁫⁪⁮⁯⁬⁪‍‭⁭‎‪⁪⁫‏‬‫​‍​‮‎‭⁮‮.\u200B‎⁯‭‬‮‎‪‭‭‬⁮‪⁯⁫⁫‏​⁫⁪‭‎‏‍‫‏⁮⁫‭‪‎⁪​⁪⁮‌‭⁯⁫⁭‮) != num2 ? 1795771748 : (num4 = 131202829);
          num1 = num4 ^ (int) num3 * -1466391091;
          continue;
        case 6:
          numArray = this.\u200D⁬‍‪‌‮‎‍⁭‎⁮⁭⁯‭⁬⁫‮⁪‮⁪⁫‎‫⁯⁫⁪‭⁪‎‭‫‫‍​‍‮‫⁭‫‮‮;
          num1 = (int) num3 * -235646049 ^ 152571200;
          continue;
        case 8:
          int num5;
          num1 = num5 = index < numArray.Length ? -901422571 : (num5 = -1497172480);
          continue;
        case 9:
          num1 = (int) num3 * -544762160 ^ -1325655710;
          continue;
        case 10:
          flag = false;
          num1 = (int) num3 * 543120918 ^ 636936614;
          continue;
        case 11:
          num1 = (int) num3 * 883268684 ^ 1690424761;
          continue;
        case 12:
          index = 0;
          num1 = (int) num3 * -1213535737 ^ 1929782653;
          continue;
        case 13:
          num2 = numArray[index];
          num1 = -1039563868;
          continue;
        case 14:
          ++index;
          num1 = (int) num3 * -883890419 ^ -1969348964;
          continue;
        default:
          goto label_16;
      }
    }
label_16:
    return flag;
  }

  static void \u202D‏⁬‫⁯⁬‌⁫‫‌⁪‫⁮⁯​‏⁪‏‬‭⁯⁯⁯⁪⁪‌‏​‎‭⁪‭⁪⁮⁯⁬⁪‭‫⁮‮([In] Array obj0, [In] RuntimeFieldHandle obj1) => RuntimeHelpers.InitializeArray(obj0, obj1);

  static void \u206F⁯⁮‎‫‎⁭‫⁭‍‫⁬​​‪⁪⁮‮⁮⁯​⁯‫‌‏⁬‫⁫⁫⁮⁮‬⁪‍‎⁪‎⁬‪⁭‮([In] string obj0) => Console.Write(obj0);

  static string \u202E‏‏⁬‍⁫‪‭‎‬‍⁮‫​⁯‪‎‫‏​​‌‫‭‬⁭⁬‮⁪‎‏‮‬⁭‬‍‏⁬⁭⁯‮() => Console.ReadLine();

  static void \u202C‫‎⁬⁮⁬‍‮​‪‎⁭‎‍‭‎‫‌⁫‏‭‍⁪‌‭‎‫‌‮⁭‫⁮⁮⁮‭‏‌​‍‌‮() => Console.Clear();

  static string \u202C⁫‭⁭‏‭‫⁪⁫‭‭⁬‬⁫‭‍‮⁭⁪‭⁬​‮‭⁫‪⁫‫​⁭⁯​‍‌‫⁪⁯⁮⁬‮‮(
    [In] string obj0,
    [In] object obj1,
    [In] object obj2)
  {
    return string.Format(obj0, obj1, obj2);
  }

  static bool \u206D‌⁭‫‭‬‮⁫⁭‎⁫‫‎⁯‮⁪⁯⁪‪⁪⁬‭‌⁪⁬‫⁮⁮‏‭⁯‎⁪‭‪‍‍‭⁬‬‮([In] string obj0, [In] string obj1) => obj0 == obj1;

  static void \u202D‬‍‫⁫‭‌‬‭⁭‫‏⁯‏‏⁭‬⁭‫⁪‏‫‌⁮‍‏​‮‬⁭‭‫⁮​⁬⁫‌⁯‭⁮‮([In] string obj0) => Console.WriteLine(obj0);

  static string \u200F‏‌⁫​​‮‭‌‏​‪‏‪‎‫‎⁬⁫​‪⁫‭‭‍‪‏‫‌‌‎‮​‫⁮⁮‪⁪‌⁬‮(
    [In] string obj0,
    [In] string obj1,
    [In] string obj2)
  {
    return obj0 + obj1 + obj2;
  }
}
