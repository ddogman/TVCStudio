﻿using System.Collections.Generic;

namespace TVC.Basic
{
    public static class TvcBasicTokenLibrary
    {
        public static Dictionary<string, byte> BasicTokens { get; } =
            new Dictionary<string, byte>
            {
                {")",0x95 },
                {"(",0x96 },
                {"&",0x97 },
                {"+",0x98 },
                {"<",0x99 },
                {"=",0x9A },
                {"<=",0x9B },
                {">",0x9C },
                {"<>",0x9D },
                {">=",0x9E },
                {"^",0x9F },

                { ";",0xA0 },
                {"/",0xA1 },
                {"-",0xA2 },
                {"=<",0xA3 },
                {",",0xA4 },
                {"><",0xA5 },
                {"=>",0xA6 },
                {"#",0xA7 },
                {"*",0xA8 },
                {"POLYGON",0xAB },
                {"RECTANGLE",0xAC },
                {"ELLIPSE",0xAD },
                {"BORDER",0xAE },
                {"USING",0xAF },

                { "AT",0xB0 },
                {"ATN",0xB1 },
                {"XOR",0xB2 },
                {"VOLUME",0xB3 },
                {"TO",0xB4 },
                {"THEN",0xB5 },
                {"TAB",0xB6 },
                {"STYLE",0xB7 },
                {"STEP",0xB8 },
                {"RATE",0xB9 },
                {"PROMPT",0xBA },
                {"PITCH",0xBB },
                {"PAPER",0xBC },
                {"PALETTE",0xBD },
                {"PAINT",0xBE },
                {"OR",0xBF },

                { "ORD",0xC0 },
                {"OFF",0xC1 },
                {"NOT",0xC2 },
                {"MODE",0xC3 },
                {"INK",0xC4 },
                {"INKEY$",0xC5 },
                {"DURATION",0xC6 },
                {"DELAY",0xC7 },
                {"CHARACTER",0xC8 },
                {"AND",0xC9 },
                {"EXCEPTION",0xCC },
                {"RENUMBER",0xCD },
                {"FKEY",0xCE },
                {"AUTO",0xCF },

                {"LPRINT",0xD0 },
                {"EXT",0xD1 },
                {"VERIFY",0xD2 },
                {"TRACE",0xD3 },
                {"STOP",0xD4 },
                {"SOUND",0xD5 },
                {"SET",0xD6 },
                {"SAVE",0xD7 },
                {"RUN",0xD8 },
                {"RETURN",0xD9 },
                {"RESTORE",0xDA },
                {"READ",0xDB },
                {"RANDOMIZE",0xDC },
                {"PRINT",0xDD },
                {"POKE",0xDE },
                {"PLOT",0xDF },

                { "OUT",0xE0 },
                {"OUTPUT",0xE1 },
                {"OPEN",0xE2 },
                {"ON",0xE3 },
                {"OK",0xE4 },
                {"NEXT",0xE5 },
                {"NEW",0xE6 },
                {"LOMEM",0xE7 },
                {"LOAD",0xE8 },
                {"LLIST",0xE9 },
                {"LIST",0xEA },
                {"LET",0xEB },
                {"INPUT",0xEC },
                {"IF",0xED },
                {"GRAPHICS",0xEE },
                {"GOTO",0xEF },

                { "GOSUB",0xF0 },
                {"GET",0xF1 },
                {"FOR",0xF2 },
                {"END",0xF3 },
                {"ELSE",0xF4 },
                {"DIM",0xF5 },
                {"DELETE",0xF6 },
                {"DEF",0xF7 },
                {"CONTINUE",0xF8 },
                {"CLS",0xF9 },
                {"CLOSE",0xFA },
                {"DATA",0xFB },
                {"REM",0xFC },
                {":",0xFD },
                {"!",0xFE }
            };
    }
}