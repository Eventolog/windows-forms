using System;
using System.Windows.Forms;

public static class MessageBoxUtility
{
    // Show an informational message
    public static void ShowInfo(string message, string title = "Information")
    {
        MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    // Show an alert message (warning)
    public static void ShowAlert(string message, string title = "Alert")
    {
        MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    // Show an error message
    public static void ShowError(string message, string title = "Error")
    {
        MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    // Show a confirmation dialog and return a boolean (true if OK, false if Cancel)
    public static bool ShowConfirm(string message, string title = "Confirm")
    {
        var result = MessageBox.Show(message, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        return result == DialogResult.OK;
    }
}
