using System;
using System.Windows.Forms;

public static class MessageBoxUtility
{
    /// <summary>
    /// Displays an informational message to the user.
    /// </summary>
    /// <param name="message">The message to display in the message box.</param>
    /// <param name="title">The title of the message box (default is "Information").</param>
    public static void ShowInfo(string message, string title = "Information")
    {
        MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    /// <summary>
    /// Displays an alert message (warning) to the user.
    /// </summary>
    /// <param name="message">The message to display in the message box.</param>
    /// <param name="title">The title of the message box (default is "Alert").</param>
    public static void ShowAlert(string message, string title = "Alert")
    {
        MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    /// <summary>
    /// Displays an error message to the user.
    /// </summary>
    /// <param name="message">The message to display in the message box.</param>
    /// <param name="title">The title of the message box (default is "Error").</param>
    public static void ShowError(string message, string title = "Error")
    {
        MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    /// <summary>
    /// Displays a confirmation dialog to the user, allowing them to select OK or Cancel.
    /// </summary>
    /// <param name="message">The message to display in the confirmation dialog.</param>
    /// <param name="title">The title of the confirmation dialog (default is "Confirm").</param>
    /// <returns>True if the user selects OK, false if the user selects Cancel.</returns>
    public static bool ShowConfirm(string message, string title = "Confirm")
    {
        var result = MessageBox.Show(message, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        return result == DialogResult.OK;
    }
}
