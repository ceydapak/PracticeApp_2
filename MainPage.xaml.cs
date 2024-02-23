using PracticeApp3.Data;

namespace PracticeApp3
{
    public partial class MainPage : ContentPage
    {

        private ViewModel _viewModel;
        public MainPage()
        {
            InitializeComponent();
            _viewModel = new ViewModel();
            BindingContext = _viewModel;
            label1.IsVisible = false;
            label2.IsVisible = false;
            label3.IsVisible = false;

        }



        private void save_C(object sender, EventArgs e)
        {

            label1.IsVisible = true;
            label2.IsVisible = true;
            label3.IsVisible = true;

        }

        private void current_PickerSelect(object sender, EventArgs e)
        {
            int selectedIndex = current.SelectedIndex;

            if (selectedIndex != -1)
            {
                string selectedCurrentCode = current.Items[selectedIndex];
                if (selectedCurrentCode != null)
                {
                    label1.Text = selectedCurrentCode;
                    var orders = _viewModel.Orders.Where(x => x.CurrentCode == selectedCurrentCode).ToList();
                    if (orders != null)
                    {
                        order.ItemsSource = orders;
                        orderItems.SelectedItem = null;

                    }

                }

            }

        }

        private void order_PickerSelect(object sender, EventArgs e)
        {
            int selectedIndex = order.SelectedIndex;

            if (selectedIndex != -1)
            {
                string selectedOrderId = order.Items[selectedIndex];
                if (selectedOrderId != null)
                {
                    label2.Text = selectedOrderId;
                    var orderIs = _viewModel.OrderItems.Where(x => x.OrderId == selectedOrderId).ToList();
                    if (orderIs != null)
                    {
                        orderItems.ItemsSource = orderIs;
                       

                    }

                }

            }
        }

        private void orderItems_PickerSelect(object sender, EventArgs e)
        {
            int selectedIndex = orderItems.SelectedIndex;

            if (selectedIndex != -1)
            {
                string selectedDoc = orderItems.Items[selectedIndex];
                if (selectedDoc != null)
                {
                    label3.Text = selectedDoc;
                }

            }
        }

    }
}
