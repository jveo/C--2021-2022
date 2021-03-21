// Decompiled with JetBrains decompiler
// Type: ‌‪‌‫‍‭‭⁬‬‬⁪‌‭‍‫‫⁯⁮⁮‭⁬⁯⁭⁫‍⁮⁪‫⁫‌‌‭‫‪‭‌‬⁪‌‌‮
// Assembly: TicTacToe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9D9D4A6E-BB82-4124-BCB7-CCCD5CE14282
// Assembly location: C:\Users\jesse\Desktop\school2021-2022\C#\Week 3\TicTacToe\TicTacToe.exe

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[CompilerGenerated]
internal sealed class \u200C‪‌‫‍‭‭⁬‬‬⁪‌‭‍‫‫⁯⁮⁮‭⁬⁯⁭⁫‍⁮⁪‫⁫‌‌‭‫‪‭‌‬⁪‌‌‮
{
  internal static readonly \u200C‪‌‫‍‭‭⁬‬‬⁪‌‭‍‫‫⁯⁮⁮‭⁬⁯⁭⁫‍⁮⁪‫⁫‌‌‭‫‪‭‌‬⁪‌‌‮.\u202D‭⁫⁬⁯‏⁪‬‎‍‭‏‏‫⁪‪⁫​​‌⁫‌⁬⁪‮⁪‪⁪‏‭‎‏‫‭⁪‫⁬⁫​⁪‮ F147385656CD52790F59E6FB8A88C5027575145E4A87809B341A722222823382;

  internal static uint \u206D⁮‮⁭⁫‌⁯⁫⁪‏‏‫‏⁫‬⁫⁯⁯⁭⁭​‏​​⁭​⁭‫‎⁮‮⁮⁭⁪‭‍‏⁪⁬‭‮(string _param0)
  {
    uint num1;
    if (_param0 != null)
    {
label_1:
      int num2 = 41041290;
      int num3;
      while (true)
      {
        uint num4;
        switch ((num4 = (uint) (num2 ^ 1548395276)) % 9U)
        {
          case 0:
            num2 = (int) num4 * 1507836745 ^ 202848644;
            continue;
          case 1:
            num1 = 2166136261U;
            num2 = (int) num4 * 1988483596 ^ -513337999;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated method
            num1 = (uint) (((int) \u200C‪‌‫‍‭‭⁬‬‬⁪‌‭‍‫‫⁯⁮⁮‭⁬⁯⁭⁫‍⁮⁪‫⁫‌‌‭‫‪‭‌‬⁪‌‌‮.\u206C‎‮‎‭‍‎‬‍⁬⁪‫‌‫‪‭‌‪‪‌⁮‮⁪‪⁪‍‭‌⁭⁮⁮‏‌⁪‭⁫‭‍⁬‏‮(_param0, num3) ^ (int) num1) * 16777619);
            num2 = 711526206;
            continue;
          case 4:
            goto label_1;
          case 5:
            int num5;
            // ISSUE: reference to a compiler-generated method
            num2 = num5 = num3 < \u200C‪‌‫‍‭‭⁬‬‬⁪‌‭‍‫‫⁯⁮⁮‭⁬⁯⁭⁫‍⁮⁪‫⁫‌‌‭‫‪‭‌‬⁪‌‌‮.\u200E⁪‍‮‎​‮⁬‫⁬‭‫⁭‎​⁫‫​‮⁮‌‬‬⁯‏⁮⁬⁯⁭​‮‌‍‮⁯‪‪​‫⁮‮(_param0) ? 562614709 : (num5 = 1283143049);
            continue;
          case 6:
            num2 = (int) num4 * -1089938084 ^ 1690011593;
            continue;
          case 7:
            ++num3;
            num2 = (int) num4 * -1399534919 ^ 315696871;
            continue;
          case 8:
            num3 = 0;
            num2 = (int) num4 * 897396354 ^ 610046995;
            continue;
          default:
            goto label_10;
        }
      }
    }
label_10:
    return num1;
  }

  static char \u206C‎‮‎‭‍‎‬‍⁬⁪‫‌‫‪‭‌‪‪‌⁮‮⁪‪⁪‍‭‌⁭⁮⁮‏‌⁪‭⁫‭‍⁬‏‮([In] string obj0, [In] int obj1) => obj0[obj1];

  static int \u200E⁪‍‮‎​‮⁬‫⁬‭‫⁭‎​⁫‫​‮⁮‌‬‬⁯‏⁮⁬⁯⁭​‮‌‍‮⁯‪‪​‫⁮‮([In] string obj0) => obj0.Length;

  [StructLayout(LayoutKind.Explicit, Size = 32, Pack = 1)]
  private struct \u202D‭⁫⁬⁯‏⁪‬‎‍‭‏‏‫⁪‪⁫​​‌⁫‌⁬⁪‮⁪‪⁪‏‭‎‏‫‭⁪‫⁬⁫​⁪‮
  {
  }
}
