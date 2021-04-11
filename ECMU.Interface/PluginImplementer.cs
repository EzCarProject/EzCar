using System;
using System.Drawing;
using System.Windows.Forms;

namespace ECMU.Interface
{
    public interface PluginImplementer
    {
        string PluginName();
        string PluginVersion();
        string PluginAuthor();
        string PluginSignature();
        string PluginDescription();
        void ButtonAdder(Button btn);
        void MenuAdder(ToolStripMenuItem tsi);
        Icon PluginIcon();
    }

    [Obsolete("We have recently decided to make the PluginImplementerAll, PluginImplementerButton and PluginImplementerMenu as obsolete. Please use PluginImplementer instead.")]
    public interface PluginImplementerButton : PluginImplementer
    {

    }

    [Obsolete("We have recently decided to make the PluginImplementerAll, PluginImplementerButton and PluginImplementerMenu as obsolete. Please use PluginImplementer instead.")]
    public interface PluginImplementerMenu : PluginImplementer
    {

    }

    [Obsolete("We have recently decided to make the PluginImplementerAll, PluginImplementerButton and PluginImplementerMenu as obsolete. Please use PluginImplementer instead.")]
    public interface PluginImplementerAll : PluginImplementer, PluginImplementerButton, PluginImplementerMenu
    {

    }
}