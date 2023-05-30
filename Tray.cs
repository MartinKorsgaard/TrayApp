using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrayApp
{
    internal class Tray : ApplicationContext
    {
        private NotifyIcon _trayIcon;

        public Tray()
        {
            _trayIcon = new NotifyIcon()
            {
                Icon = new Icon("icon.ico"),
                ContextMenuStrip = new ContextMenuStrip
                {
                    Items =
                    {
                        new ToolStripMenuItem("Test", null, new EventHandler(OnTest), "TEST"),
                        new ToolStripSeparator(),
                        new ToolStripMenuItem("Exit", null, new EventHandler(OnExit), "EXIT")
            }
                },
                Visible = true
            };
        }

        public void OnTest(object? sender, EventArgs e)
        {
            // do stuff here
            MessageBox.Show("TEST was clicked!");
        }

        public void OnExit(object? sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
