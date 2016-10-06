            OrderingSystem.PennyPetOrderingDataSet pennyPetOrderingDataSet = ((OrderingSystem.PennyPetOrderingDataSet)(this.FindResource("pennyPetOrderingDataSet")));
            // Load data into the table OrderItem. You can modify this code as needed.
            OrderingSystem.PennyPetOrderingDataSetTableAdapters.OrderItemTableAdapter pennyPetOrderingDataSetOrderItemTableAdapter = new OrderingSystem.PennyPetOrderingDataSetTableAdapters.OrderItemTableAdapter();
            pennyPetOrderingDataSetOrderItemTableAdapter.Fill(pennyPetOrderingDataSet.OrderItem);
            System.Windows.Data.CollectionViewSource orderItemViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("orderItemViewSource")));
            orderItemViewSource.View.MoveCurrentToFirst();



                    Title="PennyPet" Height="450" Width="650" Loaded="Window_Loaded">
    <Window.Resources>
        <local:PennyPetOrderingDataSet x:Key="pennyPetOrderingDataSet"/>
        <CollectionViewSource x:Key="orderItemViewSource" Source="{Binding OrderItem, Source={StaticResource pennyPetOrderingDataSet}}"/>