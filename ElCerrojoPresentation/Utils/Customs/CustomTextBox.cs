namespace ElCerrojoPresentation.Utils.Customs
{
    public static class CustomTextBox
    {
        public static void ValidateNumber(this TextBox textBox)
        {
            textBox.KeyPress += (sender, e) =>
            {
                if (char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
            };
        }

        public static void ValidateDecimalNumber(this TextBox textBox)
        {
            textBox.KeyPress += (sender, e) =>
            {
                if (char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    if (char.IsControl(e.KeyChar) || (e.KeyChar.ToString() == "," && !textBox.Text.Contains(',')))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            };
        }
    }
}
