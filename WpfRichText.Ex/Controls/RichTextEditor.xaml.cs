using System.Windows;
using System.Windows.Controls;

namespace WpfRichText.Ex.Controls
{
    /// <summary>
    /// Interaction logic for BindableRichTextbox.xaml
    /// </summary>
    public partial class RichTextEditor : UserControl
    {
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(RichTextEditor),
            new PropertyMetadata(string.Empty));
        public static readonly DependencyProperty ToolbarVisibilityProperty =
            DependencyProperty.Register("ToolbarVisibility", typeof(Visibility), typeof(RichTextEditor),
            new PropertyMetadata(Visibility.Visible));
        public static readonly DependencyProperty EditorHeightProperty =
            DependencyProperty.Register("EditorHeight", typeof(string), typeof(RichTextEditor),
            new PropertyMetadata("Auto"));

        public RichTextEditor()
        {
            InitializeComponent();
        }

        public string Text
        {
            get { return GetValue(TextProperty) as string; }
            set
            {
                SetValue(TextProperty, value);
            }
        }

        public Visibility ToolbarVisibility
        {
            get { return (Visibility)GetValue(ToolbarVisibilityProperty); }
            set
            {
                SetValue(ToolbarVisibilityProperty, value);
            }
        }

        public string EditorHeight
        {
            get { return (string)GetValue(ToolbarVisibilityProperty); }
            set
            {
                SetValue(ToolbarVisibilityProperty, value);
            }
        }
    }
}
