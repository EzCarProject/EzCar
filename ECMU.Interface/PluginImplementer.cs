﻿using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ECMU.Interface
{
    public interface PluginImplementer
    {
        string PluginName();
        string PluginVersion();
        string PluginAuthor();
        string AuthorSignature();
        string PluginDescription();
        Icon PluginIcon();
    }

    public interface PluginImplementerButton : PluginImplementer
    {
        void ButtonAdder(Button btn);
    }

    public interface PluginImplementerMenu : PluginImplementer
    {
        void MenuAdder(ToolStripMenuItem tsi);
    }

    public interface PluginImplementerAll : PluginImplementer, PluginImplementerButton, PluginImplementerMenu
    {

    }

    public static class StringUtil
    {
        private static byte[] key = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
        private static byte[] iv = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };

        public static string Crypt(this string text)
        {
            SymmetricAlgorithm algorithm = DES.Create();
            ICryptoTransform transform = algorithm.CreateEncryptor(key, iv);
            byte[] inputbuffer = Encoding.Unicode.GetBytes(text);
            byte[] outputBuffer = transform.TransformFinalBlock(inputbuffer, 0, inputbuffer.Length);
            return Convert.ToBase64String(outputBuffer);
        }

        public static string Decrypt(this string text)
        {
            SymmetricAlgorithm algorithm = DES.Create();
            ICryptoTransform transform = algorithm.CreateDecryptor(key, iv);
            byte[] inputbuffer = Convert.FromBase64String(text);
            byte[] outputBuffer = transform.TransformFinalBlock(inputbuffer, 0, inputbuffer.Length);
            return Encoding.Unicode.GetString(outputBuffer);
        }
    }
}