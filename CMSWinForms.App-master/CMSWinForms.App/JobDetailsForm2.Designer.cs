namespace CMSWinForms.App
{
    partial class JobDetailsForm2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobDetailsForm2));
            System.Windows.Forms.Label carNoLabel;
            System.Windows.Forms.Label jobDateLabel;
            System.Windows.Forms.Label workerIdLabel;
            System.Windows.Forms.Label kMsLabel;
            System.Windows.Forms.Label tuningLabel;
            System.Windows.Forms.Label alignmentLabel;
            System.Windows.Forms.Label balancingLabel;
            System.Windows.Forms.Label triesLabel;
            System.Windows.Forms.Label weightsLabel;
            System.Windows.Forms.Label oilChangedLabel;
            System.Windows.Forms.Label oilQtyLabel;
            System.Windows.Forms.Label oilFilterLabel;
            System.Windows.Forms.Label gearOilLabel;
            System.Windows.Forms.Label gearOilQtyLabel;
            System.Windows.Forms.Label pointLabel;
            System.Windows.Forms.Label condenserLabel;
            System.Windows.Forms.Label plugLabel;
            System.Windows.Forms.Label plugQtyLabel;
            System.Windows.Forms.Label fuelFilterLabel;
            System.Windows.Forms.Label airFilterLabel;
            System.Windows.Forms.Label remarksLabel;
            this.cMSDBDataSet = new CMSWinForms.App.CMSDBDataSet();
            this.tblJobDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblJobDetailTableAdapter = new CMSWinForms.App.CMSDBDataSetTableAdapters.tblJobDetailTableAdapter();
            this.tableAdapterManager = new CMSWinForms.App.CMSDBDataSetTableAdapters.TableAdapterManager();
            this.tblJobDetailBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tblJobDetailBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.carNoTextBox = new System.Windows.Forms.TextBox();
            this.jobDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.workerIdTextBox = new System.Windows.Forms.TextBox();
            this.kMsTextBox = new System.Windows.Forms.TextBox();
            this.tuningTextBox = new System.Windows.Forms.TextBox();
            this.alignmentTextBox = new System.Windows.Forms.TextBox();
            this.balancingTextBox = new System.Windows.Forms.TextBox();
            this.triesTextBox = new System.Windows.Forms.TextBox();
            this.weightsTextBox = new System.Windows.Forms.TextBox();
            this.oilChangedTextBox = new System.Windows.Forms.TextBox();
            this.oilQtyTextBox = new System.Windows.Forms.TextBox();
            this.oilFilterTextBox = new System.Windows.Forms.TextBox();
            this.gearOilTextBox = new System.Windows.Forms.TextBox();
            this.gearOilQtyTextBox = new System.Windows.Forms.TextBox();
            this.pointTextBox = new System.Windows.Forms.TextBox();
            this.condenserTextBox = new System.Windows.Forms.TextBox();
            this.plugTextBox = new System.Windows.Forms.TextBox();
            this.plugQtyTextBox = new System.Windows.Forms.TextBox();
            this.fuelFilterTextBox = new System.Windows.Forms.TextBox();
            this.airFilterTextBox = new System.Windows.Forms.TextBox();
            this.remarksTextBox = new System.Windows.Forms.TextBox();
            carNoLabel = new System.Windows.Forms.Label();
            jobDateLabel = new System.Windows.Forms.Label();
            workerIdLabel = new System.Windows.Forms.Label();
            kMsLabel = new System.Windows.Forms.Label();
            tuningLabel = new System.Windows.Forms.Label();
            alignmentLabel = new System.Windows.Forms.Label();
            balancingLabel = new System.Windows.Forms.Label();
            triesLabel = new System.Windows.Forms.Label();
            weightsLabel = new System.Windows.Forms.Label();
            oilChangedLabel = new System.Windows.Forms.Label();
            oilQtyLabel = new System.Windows.Forms.Label();
            oilFilterLabel = new System.Windows.Forms.Label();
            gearOilLabel = new System.Windows.Forms.Label();
            gearOilQtyLabel = new System.Windows.Forms.Label();
            pointLabel = new System.Windows.Forms.Label();
            condenserLabel = new System.Windows.Forms.Label();
            plugLabel = new System.Windows.Forms.Label();
            plugQtyLabel = new System.Windows.Forms.Label();
            fuelFilterLabel = new System.Windows.Forms.Label();
            airFilterLabel = new System.Windows.Forms.Label();
            remarksLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cMSDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblJobDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblJobDetailBindingNavigator)).BeginInit();
            this.tblJobDetailBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // cMSDBDataSet
            // 
            this.cMSDBDataSet.DataSetName = "CMSDBDataSet";
            this.cMSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblJobDetailBindingSource
            // 
            this.tblJobDetailBindingSource.DataMember = "tblJobDetail";
            this.tblJobDetailBindingSource.DataSource = this.cMSDBDataSet;
            // 
            // tblJobDetailTableAdapter
            // 
            this.tblJobDetailTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblCustomerTableAdapter = null;
            this.tableAdapterManager.tblJobDetailTableAdapter = this.tblJobDetailTableAdapter;
            this.tableAdapterManager.tblWorkerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CMSWinForms.App.CMSDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblJobDetailBindingNavigator
            // 
            this.tblJobDetailBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblJobDetailBindingNavigator.BindingSource = this.tblJobDetailBindingSource;
            this.tblJobDetailBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblJobDetailBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblJobDetailBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tblJobDetailBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tblJobDetailBindingNavigatorSaveItem});
            this.tblJobDetailBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblJobDetailBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblJobDetailBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblJobDetailBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblJobDetailBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblJobDetailBindingNavigator.Name = "tblJobDetailBindingNavigator";
            this.tblJobDetailBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblJobDetailBindingNavigator.Size = new System.Drawing.Size(873, 33);
            this.tblJobDetailBindingNavigator.TabIndex = 0;
            this.tblJobDetailBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 20);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 20);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 30);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(46, 24);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "新添";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "删除";
            // 
            // tblJobDetailBindingNavigatorSaveItem
            // 
            this.tblJobDetailBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblJobDetailBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblJobDetailBindingNavigatorSaveItem.Image")));
            this.tblJobDetailBindingNavigatorSaveItem.Name = "tblJobDetailBindingNavigatorSaveItem";
            this.tblJobDetailBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tblJobDetailBindingNavigatorSaveItem.Text = "保存数据";
            this.tblJobDetailBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblJobDetailBindingNavigatorSaveItem_Click);
            // 
            // carNoLabel
            // 
            carNoLabel.AutoSize = true;
            carNoLabel.Location = new System.Drawing.Point(94, 64);
            carNoLabel.Name = "carNoLabel";
            carNoLabel.Size = new System.Drawing.Size(71, 18);
            carNoLabel.TabIndex = 1;
            carNoLabel.Text = "Car No:";
            // 
            // carNoTextBox
            // 
            this.carNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblJobDetailBindingSource, "CarNo", true));
            this.carNoTextBox.Location = new System.Drawing.Point(171, 61);
            this.carNoTextBox.Name = "carNoTextBox";
            this.carNoTextBox.Size = new System.Drawing.Size(100, 28);
            this.carNoTextBox.TabIndex = 2;
            // 
            // jobDateLabel
            // 
            jobDateLabel.AutoSize = true;
            jobDateLabel.Location = new System.Drawing.Point(76, 99);
            jobDateLabel.Name = "jobDateLabel";
            jobDateLabel.Size = new System.Drawing.Size(89, 18);
            jobDateLabel.TabIndex = 3;
            jobDateLabel.Text = "Job Date:";
            // 
            // jobDateDateTimePicker
            // 
            this.jobDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblJobDetailBindingSource, "JobDate", true));
            this.jobDateDateTimePicker.Location = new System.Drawing.Point(171, 95);
            this.jobDateDateTimePicker.Name = "jobDateDateTimePicker";
            this.jobDateDateTimePicker.Size = new System.Drawing.Size(100, 28);
            this.jobDateDateTimePicker.TabIndex = 4;
            // 
            // workerIdLabel
            // 
            workerIdLabel.AutoSize = true;
            workerIdLabel.Location = new System.Drawing.Point(67, 132);
            workerIdLabel.Name = "workerIdLabel";
            workerIdLabel.Size = new System.Drawing.Size(98, 18);
            workerIdLabel.TabIndex = 5;
            workerIdLabel.Text = "Worker Id:";
            // 
            // workerIdTextBox
            // 
            this.workerIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblJobDetailBindingSource, "WorkerId", true));
            this.workerIdTextBox.Location = new System.Drawing.Point(171, 129);
            this.workerIdTextBox.Name = "workerIdTextBox";
            this.workerIdTextBox.Size = new System.Drawing.Size(100, 28);
            this.workerIdTextBox.TabIndex = 6;
            // 
            // kMsLabel
            // 
            kMsLabel.AutoSize = true;
            kMsLabel.Location = new System.Drawing.Point(121, 176);
            kMsLabel.Name = "kMsLabel";
            kMsLabel.Size = new System.Drawing.Size(44, 18);
            kMsLabel.TabIndex = 7;
            kMsLabel.Text = "KMs:";
            // 
            // kMsTextBox
            // 
            this.kMsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblJobDetailBindingSource, "KMs", true));
            this.kMsTextBox.Location = new System.Drawing.Point(171, 166);
            this.kMsTextBox.Name = "kMsTextBox";
            this.kMsTextBox.Size = new System.Drawing.Size(100, 28);
            this.kMsTextBox.TabIndex = 8;
            // 
            // tuningLabel
            // 
            tuningLabel.AutoSize = true;
            tuningLabel.Location = new System.Drawing.Point(94, 210);
            tuningLabel.Name = "tuningLabel";
            tuningLabel.Size = new System.Drawing.Size(71, 18);
            tuningLabel.TabIndex = 9;
            tuningLabel.Text = "Tuning:";
            // 
            // tuningTextBox
            // 
            this.tuningTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblJobDetailBindingSource, "Tuning", true));
            this.tuningTextBox.Location = new System.Drawing.Point(171, 207);
            this.tuningTextBox.Name = "tuningTextBox";
            this.tuningTextBox.Size = new System.Drawing.Size(100, 28);
            this.tuningTextBox.TabIndex = 10;
            // 
            // alignmentLabel
            // 
            alignmentLabel.AutoSize = true;
            alignmentLabel.Location = new System.Drawing.Point(67, 244);
            alignmentLabel.Name = "alignmentLabel";
            alignmentLabel.Size = new System.Drawing.Size(98, 18);
            alignmentLabel.TabIndex = 11;
            alignmentLabel.Text = "Alignment:";
            // 
            // alignmentTextBox
            // 
            this.alignmentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblJobDetailBindingSource, "Alignment", true));
            this.alignmentTextBox.Location = new System.Drawing.Point(171, 241);
            this.alignmentTextBox.Name = "alignmentTextBox";
            this.alignmentTextBox.Size = new System.Drawing.Size(100, 28);
            this.alignmentTextBox.TabIndex = 12;
            // 
            // balancingLabel
            // 
            balancingLabel.AutoSize = true;
            balancingLabel.Location = new System.Drawing.Point(67, 278);
            balancingLabel.Name = "balancingLabel";
            balancingLabel.Size = new System.Drawing.Size(98, 18);
            balancingLabel.TabIndex = 13;
            balancingLabel.Text = "Balancing:";
            // 
            // balancingTextBox
            // 
            this.balancingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblJobDetailBindingSource, "Balancing", true));
            this.balancingTextBox.Location = new System.Drawing.Point(171, 275);
            this.balancingTextBox.Name = "balancingTextBox";
            this.balancingTextBox.Size = new System.Drawing.Size(100, 28);
            this.balancingTextBox.TabIndex = 14;
            // 
            // triesLabel
            // 
            triesLabel.AutoSize = true;
            triesLabel.Location = new System.Drawing.Point(103, 312);
            triesLabel.Name = "triesLabel";
            triesLabel.Size = new System.Drawing.Size(62, 18);
            triesLabel.TabIndex = 15;
            triesLabel.Text = "Tries:";
            // 
            // triesTextBox
            // 
            this.triesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblJobDetailBindingSource, "Tries", true));
            this.triesTextBox.Location = new System.Drawing.Point(171, 309);
            this.triesTextBox.Name = "triesTextBox";
            this.triesTextBox.Size = new System.Drawing.Size(100, 28);
            this.triesTextBox.TabIndex = 16;
            // 
            // weightsLabel
            // 
            weightsLabel.AutoSize = true;
            weightsLabel.Location = new System.Drawing.Point(85, 346);
            weightsLabel.Name = "weightsLabel";
            weightsLabel.Size = new System.Drawing.Size(80, 18);
            weightsLabel.TabIndex = 17;
            weightsLabel.Text = "Weights:";
            // 
            // weightsTextBox
            // 
            this.weightsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblJobDetailBindingSource, "Weights", true));
            this.weightsTextBox.Location = new System.Drawing.Point(171, 343);
            this.weightsTextBox.Name = "weightsTextBox";
            this.weightsTextBox.Size = new System.Drawing.Size(100, 28);
            this.weightsTextBox.TabIndex = 18;
            // 
            // oilChangedLabel
            // 
            oilChangedLabel.AutoSize = true;
            oilChangedLabel.Location = new System.Drawing.Point(49, 380);
            oilChangedLabel.Name = "oilChangedLabel";
            oilChangedLabel.Size = new System.Drawing.Size(116, 18);
            oilChangedLabel.TabIndex = 19;
            oilChangedLabel.Text = "Oil Changed:";
            // 
            // oilChangedTextBox
            // 
            this.oilChangedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblJobDetailBindingSource, "OilChanged", true));
            this.oilChangedTextBox.Location = new System.Drawing.Point(171, 377);
            this.oilChangedTextBox.Name = "oilChangedTextBox";
            this.oilChangedTextBox.Size = new System.Drawing.Size(100, 28);
            this.oilChangedTextBox.TabIndex = 20;
            // 
            // oilQtyLabel
            // 
            oilQtyLabel.AutoSize = true;
            oilQtyLabel.Location = new System.Drawing.Point(85, 414);
            oilQtyLabel.Name = "oilQtyLabel";
            oilQtyLabel.Size = new System.Drawing.Size(80, 18);
            oilQtyLabel.TabIndex = 21;
            oilQtyLabel.Text = "Oil Qty:";
            // 
            // oilQtyTextBox
            // 
            this.oilQtyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblJobDetailBindingSource, "OilQty", true));
            this.oilQtyTextBox.Location = new System.Drawing.Point(171, 411);
            this.oilQtyTextBox.Name = "oilQtyTextBox";
            this.oilQtyTextBox.Size = new System.Drawing.Size(100, 28);
            this.oilQtyTextBox.TabIndex = 22;
            // 
            // oilFilterLabel
            // 
            oilFilterLabel.AutoSize = true;
            oilFilterLabel.Location = new System.Drawing.Point(507, 64);
            oilFilterLabel.Name = "oilFilterLabel";
            oilFilterLabel.Size = new System.Drawing.Size(107, 18);
            oilFilterLabel.TabIndex = 23;
            oilFilterLabel.Text = "Oil Filter:";
            // 
            // oilFilterTextBox
            // 
            this.oilFilterTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblJobDetailBindingSource, "OilFilter", true));
            this.oilFilterTextBox.Location = new System.Drawing.Point(620, 61);
            this.oilFilterTextBox.Name = "oilFilterTextBox";
            this.oilFilterTextBox.Size = new System.Drawing.Size(100, 28);
            this.oilFilterTextBox.TabIndex = 24;
            // 
            // gearOilLabel
            // 
            gearOilLabel.AutoSize = true;
            gearOilLabel.Location = new System.Drawing.Point(525, 99);
            gearOilLabel.Name = "gearOilLabel";
            gearOilLabel.Size = new System.Drawing.Size(89, 18);
            gearOilLabel.TabIndex = 25;
            gearOilLabel.Text = "Gear Oil:";
            // 
            // gearOilTextBox
            // 
            this.gearOilTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblJobDetailBindingSource, "GearOil", true));
            this.gearOilTextBox.Location = new System.Drawing.Point(620, 96);
            this.gearOilTextBox.Name = "gearOilTextBox";
            this.gearOilTextBox.Size = new System.Drawing.Size(100, 28);
            this.gearOilTextBox.TabIndex = 26;
            // 
            // gearOilQtyLabel
            // 
            gearOilQtyLabel.AutoSize = true;
            gearOilQtyLabel.Location = new System.Drawing.Point(489, 132);
            gearOilQtyLabel.Name = "gearOilQtyLabel";
            gearOilQtyLabel.Size = new System.Drawing.Size(125, 18);
            gearOilQtyLabel.TabIndex = 27;
            gearOilQtyLabel.Text = "Gear Oil Qty:";
            // 
            // gearOilQtyTextBox
            // 
            this.gearOilQtyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblJobDetailBindingSource, "GearOilQty", true));
            this.gearOilQtyTextBox.Location = new System.Drawing.Point(620, 129);
            this.gearOilQtyTextBox.Name = "gearOilQtyTextBox";
            this.gearOilQtyTextBox.Size = new System.Drawing.Size(100, 28);
            this.gearOilQtyTextBox.TabIndex = 28;
            // 
            // pointLabel
            // 
            pointLabel.AutoSize = true;
            pointLabel.Location = new System.Drawing.Point(552, 169);
            pointLabel.Name = "pointLabel";
            pointLabel.Size = new System.Drawing.Size(62, 18);
            pointLabel.TabIndex = 29;
            pointLabel.Text = "Point:";
            // 
            // pointTextBox
            // 
            this.pointTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblJobDetailBindingSource, "Point", true));
            this.pointTextBox.Location = new System.Drawing.Point(620, 166);
            this.pointTextBox.Name = "pointTextBox";
            this.pointTextBox.Size = new System.Drawing.Size(100, 28);
            this.pointTextBox.TabIndex = 30;
            // 
            // condenserLabel
            // 
            condenserLabel.AutoSize = true;
            condenserLabel.Location = new System.Drawing.Point(516, 210);
            condenserLabel.Name = "condenserLabel";
            condenserLabel.Size = new System.Drawing.Size(98, 18);
            condenserLabel.TabIndex = 31;
            condenserLabel.Text = "Condenser:";
            // 
            // condenserTextBox
            // 
            this.condenserTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblJobDetailBindingSource, "Condenser", true));
            this.condenserTextBox.Location = new System.Drawing.Point(620, 207);
            this.condenserTextBox.Name = "condenserTextBox";
            this.condenserTextBox.Size = new System.Drawing.Size(100, 28);
            this.condenserTextBox.TabIndex = 32;
            // 
            // plugLabel
            // 
            plugLabel.AutoSize = true;
            plugLabel.Location = new System.Drawing.Point(561, 244);
            plugLabel.Name = "plugLabel";
            plugLabel.Size = new System.Drawing.Size(53, 18);
            plugLabel.TabIndex = 33;
            plugLabel.Text = "Plug:";
            // 
            // plugTextBox
            // 
            this.plugTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblJobDetailBindingSource, "Plug", true));
            this.plugTextBox.Location = new System.Drawing.Point(620, 241);
            this.plugTextBox.Name = "plugTextBox";
            this.plugTextBox.Size = new System.Drawing.Size(100, 28);
            this.plugTextBox.TabIndex = 34;
            // 
            // plugQtyLabel
            // 
            plugQtyLabel.AutoSize = true;
            plugQtyLabel.Location = new System.Drawing.Point(525, 278);
            plugQtyLabel.Name = "plugQtyLabel";
            plugQtyLabel.Size = new System.Drawing.Size(89, 18);
            plugQtyLabel.TabIndex = 35;
            plugQtyLabel.Text = "Plug Qty:";
            // 
            // plugQtyTextBox
            // 
            this.plugQtyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblJobDetailBindingSource, "PlugQty", true));
            this.plugQtyTextBox.Location = new System.Drawing.Point(620, 275);
            this.plugQtyTextBox.Name = "plugQtyTextBox";
            this.plugQtyTextBox.Size = new System.Drawing.Size(100, 28);
            this.plugQtyTextBox.TabIndex = 36;
            // 
            // fuelFilterLabel
            // 
            fuelFilterLabel.AutoSize = true;
            fuelFilterLabel.Location = new System.Drawing.Point(498, 312);
            fuelFilterLabel.Name = "fuelFilterLabel";
            fuelFilterLabel.Size = new System.Drawing.Size(116, 18);
            fuelFilterLabel.TabIndex = 37;
            fuelFilterLabel.Text = "Fuel Filter:";
            // 
            // fuelFilterTextBox
            // 
            this.fuelFilterTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblJobDetailBindingSource, "FuelFilter", true));
            this.fuelFilterTextBox.Location = new System.Drawing.Point(620, 309);
            this.fuelFilterTextBox.Name = "fuelFilterTextBox";
            this.fuelFilterTextBox.Size = new System.Drawing.Size(100, 28);
            this.fuelFilterTextBox.TabIndex = 38;
            // 
            // airFilterLabel
            // 
            airFilterLabel.AutoSize = true;
            airFilterLabel.Location = new System.Drawing.Point(507, 346);
            airFilterLabel.Name = "airFilterLabel";
            airFilterLabel.Size = new System.Drawing.Size(107, 18);
            airFilterLabel.TabIndex = 39;
            airFilterLabel.Text = "Air Filter:";
            // 
            // airFilterTextBox
            // 
            this.airFilterTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblJobDetailBindingSource, "AirFilter", true));
            this.airFilterTextBox.Location = new System.Drawing.Point(620, 343);
            this.airFilterTextBox.Name = "airFilterTextBox";
            this.airFilterTextBox.Size = new System.Drawing.Size(100, 28);
            this.airFilterTextBox.TabIndex = 40;
            // 
            // remarksLabel
            // 
            remarksLabel.AutoSize = true;
            remarksLabel.Location = new System.Drawing.Point(534, 380);
            remarksLabel.Name = "remarksLabel";
            remarksLabel.Size = new System.Drawing.Size(80, 18);
            remarksLabel.TabIndex = 41;
            remarksLabel.Text = "Remarks:";
            // 
            // remarksTextBox
            // 
            this.remarksTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblJobDetailBindingSource, "Remarks", true));
            this.remarksTextBox.Location = new System.Drawing.Point(620, 377);
            this.remarksTextBox.Name = "remarksTextBox";
            this.remarksTextBox.Size = new System.Drawing.Size(100, 28);
            this.remarksTextBox.TabIndex = 42;
            // 
            // JobDetailsForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 552);
            this.Controls.Add(remarksLabel);
            this.Controls.Add(this.remarksTextBox);
            this.Controls.Add(airFilterLabel);
            this.Controls.Add(this.airFilterTextBox);
            this.Controls.Add(fuelFilterLabel);
            this.Controls.Add(this.fuelFilterTextBox);
            this.Controls.Add(plugQtyLabel);
            this.Controls.Add(this.plugQtyTextBox);
            this.Controls.Add(plugLabel);
            this.Controls.Add(this.plugTextBox);
            this.Controls.Add(condenserLabel);
            this.Controls.Add(this.condenserTextBox);
            this.Controls.Add(pointLabel);
            this.Controls.Add(this.pointTextBox);
            this.Controls.Add(gearOilQtyLabel);
            this.Controls.Add(this.gearOilQtyTextBox);
            this.Controls.Add(gearOilLabel);
            this.Controls.Add(this.gearOilTextBox);
            this.Controls.Add(oilFilterLabel);
            this.Controls.Add(this.oilFilterTextBox);
            this.Controls.Add(oilQtyLabel);
            this.Controls.Add(this.oilQtyTextBox);
            this.Controls.Add(oilChangedLabel);
            this.Controls.Add(this.oilChangedTextBox);
            this.Controls.Add(weightsLabel);
            this.Controls.Add(this.weightsTextBox);
            this.Controls.Add(triesLabel);
            this.Controls.Add(this.triesTextBox);
            this.Controls.Add(balancingLabel);
            this.Controls.Add(this.balancingTextBox);
            this.Controls.Add(alignmentLabel);
            this.Controls.Add(this.alignmentTextBox);
            this.Controls.Add(tuningLabel);
            this.Controls.Add(this.tuningTextBox);
            this.Controls.Add(kMsLabel);
            this.Controls.Add(this.kMsTextBox);
            this.Controls.Add(workerIdLabel);
            this.Controls.Add(this.workerIdTextBox);
            this.Controls.Add(jobDateLabel);
            this.Controls.Add(this.jobDateDateTimePicker);
            this.Controls.Add(carNoLabel);
            this.Controls.Add(this.carNoTextBox);
            this.Controls.Add(this.tblJobDetailBindingNavigator);
            this.Name = "JobDetailsForm2";
            this.Text = "JobDetailsForm2";
            this.Load += new System.EventHandler(this.JobDetailsForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cMSDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblJobDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblJobDetailBindingNavigator)).EndInit();
            this.tblJobDetailBindingNavigator.ResumeLayout(false);
            this.tblJobDetailBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CMSDBDataSet cMSDBDataSet;
        private System.Windows.Forms.BindingSource tblJobDetailBindingSource;
        private CMSDBDataSetTableAdapters.tblJobDetailTableAdapter tblJobDetailTableAdapter;
        private CMSDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblJobDetailBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tblJobDetailBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox carNoTextBox;
        private System.Windows.Forms.DateTimePicker jobDateDateTimePicker;
        private System.Windows.Forms.TextBox workerIdTextBox;
        private System.Windows.Forms.TextBox kMsTextBox;
        private System.Windows.Forms.TextBox tuningTextBox;
        private System.Windows.Forms.TextBox alignmentTextBox;
        private System.Windows.Forms.TextBox balancingTextBox;
        private System.Windows.Forms.TextBox triesTextBox;
        private System.Windows.Forms.TextBox weightsTextBox;
        private System.Windows.Forms.TextBox oilChangedTextBox;
        private System.Windows.Forms.TextBox oilQtyTextBox;
        private System.Windows.Forms.TextBox oilFilterTextBox;
        private System.Windows.Forms.TextBox gearOilTextBox;
        private System.Windows.Forms.TextBox gearOilQtyTextBox;
        private System.Windows.Forms.TextBox pointTextBox;
        private System.Windows.Forms.TextBox condenserTextBox;
        private System.Windows.Forms.TextBox plugTextBox;
        private System.Windows.Forms.TextBox plugQtyTextBox;
        private System.Windows.Forms.TextBox fuelFilterTextBox;
        private System.Windows.Forms.TextBox airFilterTextBox;
        private System.Windows.Forms.TextBox remarksTextBox;
    }
}