using System;
using System.Windows.Forms;

/// <summary>
/// Utility class for displaying standardized message boxes in the application.
/// Provides methods for showing informational, warning, error, and confirmation dialogs
/// with consistent styles.
/// </summary>
public static class MessageBoxUtility
{
    /// <summary>
    /// Shows an informational message box.
    /// </summary>
    /// <param name="message">The content message to display.</param>
    /// <param name="title">The window title (default: "Information").</param>
    public static void ShowInfo(string message, string title = "Information")
    {
        MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    /// <summary>
    /// Shows a warning (alert) message box.
    /// </summary>
    /// <param name="message">The content message to display.</param>
    /// <param name="title">The window title (default: "Alert").</param>
    public static void ShowAlert(string message, string title = "Alert")
    {
        MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    /// <summary>
    /// Shows an error message box.
    /// </summary>
    /// <param name="message">The content message to display.</param>
    /// <param name="title">The window title (default: "Error").</param>
    public static void ShowError(string message, string title = "Error")
    {
        MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    /// <summary>
    /// Shows a confirmation dialog box and returns true if the user clicks OK.
    /// </summary>
    /// <param name="message">The confirmation message to display.</param>
    /// <param name="title">The window title (default: "Confirm").</param>
    /// <returns>True if the user clicks OK; false if Cancel.</returns>
    public static bool ShowConfirm(string message, string title = "Confirm")
    {
        var result = MessageBox.Show(message, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        return result == DialogResult.OK;
    }
}