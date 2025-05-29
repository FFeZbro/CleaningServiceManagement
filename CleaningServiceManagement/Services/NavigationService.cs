using System.Windows.Forms;
using CleaningServiceManagement.Forms;

namespace CleaningServiceManagement.Services
{
    public static class NavigationService
    {
        private static Form _currentForm;

        public static void RedirectTo<T>() where T : Form, new()
        {
            var newForm = new T();
            ChangeForm(newForm);
        }

        public static void RedirectTo(Form form)
        {
            ChangeForm(form);
        }

        private static void ChangeForm(Form newForm)
        {
            _currentForm?.Hide();
            newForm.FormClosed += (s, args) => _currentForm?.Close();
            _currentForm = newForm;
            newForm.Show();
        }

        public static void ShowDialog<T>() where T : Form, new()
        {
            using (var dialog = new T())
            {
                dialog.ShowDialog();
            }
        }
    }
}
