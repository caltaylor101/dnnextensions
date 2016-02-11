﻿/*
 * Copyright (c) 2016, Will Strohl
 * All rights reserved.
 * 
 * Redistribution and use in source and binary forms, with or without modification, 
 * are permitted provided that the following conditions are met:
 * 
 * Redistributions of source code must retain the above copyright notice, this list 
 * of conditions and the following disclaimer.
 * 
 * Redistributions in binary form must reproduce the above copyright notice, this 
 * list of conditions and the following disclaimer in the documentation and/or 
 * other materials provided with the distribution.
 * 
 * Neither the name of Will Strohl, nor the names of its contributors may be used 
 * to endorse or promote products derived from this software without specific prior 
 * written permission.
 * 
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
 * ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
 * WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
 * IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
 * INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 
 * BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, 
 * DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF 
 * LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE 
 * OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF 
 * ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
*/

using System;

namespace WillStrohl.Modules.CodeCamp.Components
{
    public static class PasswordGenerator
    {
        private const int PASSWORD_LENGTH = 15;
        private const string CHARACTERS = "abcdefghijkmnopqrstuvwxyz23456789";
        private const string LETTERS = "abcdefghijkmnopqrstuvwxyz";

        public static string GeneratePassword()
        {
            var result = string.Empty;
            var r = new Random();

            r.Next();

            for (var i = 0; i < PASSWORD_LENGTH; i++)
            {
                r.Next();
                if (i == 0)
                {
                    result += GetRandomPrintableLetter(r);
                }
                else
                {
                    result += GetRandomPrintableCharacter(r);
                }
            }

            return result;
        }

        private static string GetRandomPrintableCharacter(Random r)
        {
            var location = r.Next(CHARACTERS.Length - 1);
            return CHARACTERS.Substring(location, 1);
        }

        private static string GetRandomPrintableLetter(Random r)
        {
            int location = r.Next(LETTERS.Length - 1);
            return LETTERS.Substring(location, 1);
        }
    }
}