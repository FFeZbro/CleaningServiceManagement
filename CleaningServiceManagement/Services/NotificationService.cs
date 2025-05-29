using System;
using System.Timers;
using System.Windows.Forms;
using CleaningServiceManagement.Models;

namespace CleaningServiceManagement.Services
{
    public static class NotificationService
    {
        private static Timer _reminderTimer;
        private static NotifyIcon _trayIcon;

        public static void Start()
        {
            InitializeTrayIcon();
            StartReminderTimer();
        }

        private static void InitializeTrayIcon()
        {
            _trayIcon = new NotifyIcon
            {
                Icon = Properties.Resources.AppIcon,
                Visible = true,
                Text = "Cleaning Service Manager"
            };
        }

        private static void StartReminderTimer()
        {
            _reminderTimer = new Timer(3600000) { Enabled = true }; // Каждый час
            _reminderTimer.Elapsed += (s, e) => CheckPendingBookings();
        }

        private static void CheckPendingBookings()
        {
            // Здесь должна быть логика проверки актуальных бронирований
            ShowNotification("Напоминание", "У вас есть предстоящие заказы");
        }

        public static void ShowNotification(string title, string message)
        {
            _trayIcon?.ShowBalloonTip(3000, title, message, ToolTipIcon.Info);
        }

        public static void Stop()
        {
            _reminderTimer?.Dispose();
            _trayIcon?.Dispose();
        }
    }
}
