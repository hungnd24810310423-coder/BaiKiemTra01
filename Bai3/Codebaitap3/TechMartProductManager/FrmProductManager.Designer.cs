namespace TechMartProductManager;

partial class FrmProductManager
{
    private System.ComponentModel.IContainer? components = null;

    private MenuStrip menuStrip1 = null!;
    private ToolStripMenuItem fileToolStripMenuItem = null!;
    private ToolStripMenuItem exportCsvToolStripMenuItem = null!;
    private ToolStripMenuItem exitToolStripMenuItem = null!;
    private StatusStrip statusStrip1 = null!;
    private ToolStripStatusLabel lblStatus = null!;

    private TableLayoutPanel mainLayout = null!;
    private TableLayoutPanel leftLayout = null!;
    private TableLayoutPanel inputLayout = null!;
    private TableLayoutPanel buttonLayout = null!;
    private TableLayoutPanel rightLayout = null!;
    private TableLayoutPanel searchLayout = null!;

    private Label lblTitle = null!;
    private Label lblProductId = null!;
    private Label lblProductName = null!;
    private Label lblUnitPrice = null!;
    private Label lblQuantity = null!;
    private Label lblCategory = null!;
    private Label lblSearch = null!;

    private TextBox txtProductId = null!;
    private TextBox txtProductName = null!;
    private TextBox txtUnitPrice = null!;
    private TextBox txtQuantity = null!;
    private ComboBox cboCategory = null!;
    private PictureBox picAvatar = null!;
    private Button btnChooseImage = null!;
    private Button btnAdd = null!;
    private Button btnUpdate = null!;
    private Button btnDelete = null!;
    private TextBox txtSearch = null!;
    private DataGridView dgvProducts = null!;
    private DataGridViewTextBoxColumn colProductId = null!;
    private DataGridViewTextBoxColumn colProductName = null!;
    private DataGridViewTextBoxColumn colCategory = null!;
    private DataGridViewTextBoxColumn colUnitPrice = null!;
    private DataGridViewTextBoxColumn colQuantity = null!;
    private ErrorProvider errorProvider = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing)
            components?.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        menuStrip1 = new MenuStrip();
        fileToolStripMenuItem = new ToolStripMenuItem();
        exportCsvToolStripMenuItem = new ToolStripMenuItem();
        exitToolStripMenuItem = new ToolStripMenuItem();
        statusStrip1 = new StatusStrip();
        lblStatus = new ToolStripStatusLabel();
        mainLayout = new TableLayoutPanel();
        leftLayout = new TableLayoutPanel();
        lblTitle = new Label();
        inputLayout = new TableLayoutPanel();
        lblProductId = new Label();
        txtProductId = new TextBox();
        lblProductName = new Label();
        txtProductName = new TextBox();
        lblUnitPrice = new Label();
        txtUnitPrice = new TextBox();
        lblQuantity = new Label();
        txtQuantity = new TextBox();
        lblCategory = new Label();
        cboCategory = new ComboBox();
        picAvatar = new PictureBox();
        btnChooseImage = new Button();
        buttonLayout = new TableLayoutPanel();
        btnAdd = new Button();
        btnUpdate = new Button();
        btnDelete = new Button();
        rightLayout = new TableLayoutPanel();
        searchLayout = new TableLayoutPanel();
        lblSearch = new Label();
        txtSearch = new TextBox();
        dgvProducts = new DataGridView();
        errorProvider = new ErrorProvider(components);
        menuStrip1.SuspendLayout();
        statusStrip1.SuspendLayout();
        mainLayout.SuspendLayout();
        leftLayout.SuspendLayout();
        inputLayout.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
        buttonLayout.SuspendLayout();
        rightLayout.SuspendLayout();
        searchLayout.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
        ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(1100, 24);
        menuStrip1.TabIndex = 0;
        // 
        // fileToolStripMenuItem
        // 
        fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exportCsvToolStripMenuItem, exitToolStripMenuItem });
        fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        fileToolStripMenuItem.Size = new Size(37, 20);
        fileToolStripMenuItem.Text = "File";
        // 
        // exportCsvToolStripMenuItem
        // 
        exportCsvToolStripMenuItem.Name = "exportCsvToolStripMenuItem";
        exportCsvToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
        exportCsvToolStripMenuItem.Size = new Size(172, 22);
        exportCsvToolStripMenuItem.Text = "Export CSV";
        exportCsvToolStripMenuItem.Click += exportCsvToolStripMenuItem_Click;
        // 
        // exitToolStripMenuItem
        // 
        exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        exitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
        exitToolStripMenuItem.Size = new Size(172, 22);
        exitToolStripMenuItem.Text = "Exit";
        exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
        // 
        // statusStrip1
        // 
        statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus });
        statusStrip1.Location = new Point(0, 638);
        statusStrip1.Name = "statusStrip1";
        statusStrip1.Size = new Size(1100, 22);
        statusStrip1.TabIndex = 1;
        // 
        // lblStatus
        // 
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new Size(116, 17);
        lblStatus.Text = "Tổng số sản phẩm: 0";
        // 
        // mainLayout
        // 
        mainLayout.ColumnCount = 2;
        mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
        mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
        mainLayout.Controls.Add(leftLayout, 0, 0);
        mainLayout.Controls.Add(rightLayout, 1, 0);
        mainLayout.Dock = DockStyle.Fill;
        mainLayout.Location = new Point(0, 24);
        mainLayout.Name = "mainLayout";
        mainLayout.Padding = new Padding(8);
        mainLayout.RowCount = 1;
        mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        mainLayout.Size = new Size(1100, 614);
        mainLayout.TabIndex = 2;
        // 
        // leftLayout
        // 
        leftLayout.ColumnCount = 1;
        leftLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        leftLayout.Controls.Add(lblTitle, 0, 0);
        leftLayout.Controls.Add(inputLayout, 0, 1);
        leftLayout.Controls.Add(picAvatar, 0, 2);
        leftLayout.Controls.Add(btnChooseImage, 0, 3);
        leftLayout.Controls.Add(buttonLayout, 0, 4);
        leftLayout.Dock = DockStyle.Fill;
        leftLayout.Location = new Point(8, 8);
        leftLayout.Margin = new Padding(0, 0, 8, 0);
        leftLayout.Name = "leftLayout";
        leftLayout.Padding = new Padding(5);
        leftLayout.RowCount = 5;
        leftLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
        leftLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 180F));
        leftLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        leftLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
        leftLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
        leftLayout.Size = new Size(371, 598);
        leftLayout.TabIndex = 0;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Dock = DockStyle.Fill;
        lblTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
        lblTitle.Location = new Point(8, 5);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(355, 42);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "THÔNG TIN SẢN PHẨM";
        lblTitle.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // inputLayout
        // 
        inputLayout.ColumnCount = 2;
        inputLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
        inputLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
        inputLayout.Controls.Add(lblProductId, 0, 0);
        inputLayout.Controls.Add(txtProductId, 1, 0);
        inputLayout.Controls.Add(lblProductName, 0, 1);
        inputLayout.Controls.Add(txtProductName, 1, 1);
        inputLayout.Controls.Add(lblUnitPrice, 0, 2);
        inputLayout.Controls.Add(txtUnitPrice, 1, 2);
        inputLayout.Controls.Add(lblQuantity, 0, 3);
        inputLayout.Controls.Add(txtQuantity, 1, 3);
        inputLayout.Controls.Add(lblCategory, 0, 4);
        inputLayout.Controls.Add(cboCategory, 1, 4);
        inputLayout.Dock = DockStyle.Fill;
        inputLayout.Location = new Point(8, 50);
        inputLayout.Name = "inputLayout";
        inputLayout.RowCount = 5;
        inputLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        inputLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        inputLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        inputLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        inputLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        inputLayout.Size = new Size(355, 174);
        inputLayout.TabIndex = 1;
        // 
        // lblProductId
        // 
        lblProductId.AutoSize = true;
        lblProductId.Dock = DockStyle.Fill;
        lblProductId.Location = new Point(3, 3);
        lblProductId.Margin = new Padding(3);
        lblProductId.Name = "lblProductId";
        lblProductId.Size = new Size(100, 28);
        lblProductId.TabIndex = 0;
        lblProductId.Text = "Mã SP";
        lblProductId.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // txtProductId
        // 
        txtProductId.Dock = DockStyle.Fill;
        txtProductId.Location = new Point(109, 5);
        txtProductId.Margin = new Padding(3, 5, 3, 5);
        txtProductId.Name = "txtProductId";
        txtProductId.Size = new Size(243, 23);
        txtProductId.TabIndex = 1;
        // 
        // lblProductName
        // 
        lblProductName.AutoSize = true;
        lblProductName.Dock = DockStyle.Fill;
        lblProductName.Location = new Point(3, 37);
        lblProductName.Margin = new Padding(3);
        lblProductName.Name = "lblProductName";
        lblProductName.Size = new Size(100, 28);
        lblProductName.TabIndex = 2;
        lblProductName.Text = "Tên SP";
        lblProductName.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // txtProductName
        // 
        txtProductName.Dock = DockStyle.Fill;
        txtProductName.Location = new Point(109, 39);
        txtProductName.Margin = new Padding(3, 5, 3, 5);
        txtProductName.Name = "txtProductName";
        txtProductName.Size = new Size(243, 23);
        txtProductName.TabIndex = 3;
        // 
        // lblUnitPrice
        // 
        lblUnitPrice.AutoSize = true;
        lblUnitPrice.Dock = DockStyle.Fill;
        lblUnitPrice.Location = new Point(3, 71);
        lblUnitPrice.Margin = new Padding(3);
        lblUnitPrice.Name = "lblUnitPrice";
        lblUnitPrice.Size = new Size(100, 28);
        lblUnitPrice.TabIndex = 4;
        lblUnitPrice.Text = "Đơn giá";
        lblUnitPrice.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // txtUnitPrice
        // 
        txtUnitPrice.Dock = DockStyle.Fill;
        txtUnitPrice.Location = new Point(109, 73);
        txtUnitPrice.Margin = new Padding(3, 5, 3, 5);
        txtUnitPrice.Name = "txtUnitPrice";
        txtUnitPrice.Size = new Size(243, 23);
        txtUnitPrice.TabIndex = 5;
        // 
        // lblQuantity
        // 
        lblQuantity.AutoSize = true;
        lblQuantity.Dock = DockStyle.Fill;
        lblQuantity.Location = new Point(3, 105);
        lblQuantity.Margin = new Padding(3);
        lblQuantity.Name = "lblQuantity";
        lblQuantity.Size = new Size(100, 28);
        lblQuantity.TabIndex = 6;
        lblQuantity.Text = "Số lượng";
        lblQuantity.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // txtQuantity
        // 
        txtQuantity.Dock = DockStyle.Fill;
        txtQuantity.Location = new Point(109, 107);
        txtQuantity.Margin = new Padding(3, 5, 3, 5);
        txtQuantity.Name = "txtQuantity";
        txtQuantity.Size = new Size(243, 23);
        txtQuantity.TabIndex = 7;
        // 
        // lblCategory
        // 
        lblCategory.AutoSize = true;
        lblCategory.Dock = DockStyle.Fill;
        lblCategory.Location = new Point(3, 139);
        lblCategory.Margin = new Padding(3);
        lblCategory.Name = "lblCategory";
        lblCategory.Size = new Size(100, 32);
        lblCategory.TabIndex = 8;
        lblCategory.Text = "Danh mục";
        lblCategory.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // cboCategory
        // 
        cboCategory.Dock = DockStyle.Fill;
        cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
        cboCategory.Location = new Point(109, 141);
        cboCategory.Margin = new Padding(3, 5, 3, 5);
        cboCategory.Name = "cboCategory";
        cboCategory.Size = new Size(243, 23);
        cboCategory.TabIndex = 9;
        // 
        // picAvatar
        // 
        picAvatar.BorderStyle = BorderStyle.FixedSingle;
        picAvatar.Dock = DockStyle.Fill;
        picAvatar.Location = new Point(8, 230);
        picAvatar.Name = "picAvatar";
        picAvatar.Size = new Size(355, 267);
        picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
        picAvatar.TabIndex = 6;
        picAvatar.TabStop = false;
        // 
        // btnChooseImage
        // 
        btnChooseImage.AutoSize = true;
        btnChooseImage.Dock = DockStyle.Left;
        btnChooseImage.Location = new Point(8, 503);
        btnChooseImage.Name = "btnChooseImage";
        btnChooseImage.Size = new Size(69, 32);
        btnChooseImage.TabIndex = 7;
        btnChooseImage.Text = "Chọn ảnh";
        btnChooseImage.Click += btnChooseImage_Click;
        // 
        // buttonLayout
        // 
        buttonLayout.ColumnCount = 3;
        buttonLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.333F));
        buttonLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.333F));
        buttonLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.333F));
        buttonLayout.Controls.Add(btnAdd, 0, 0);
        buttonLayout.Controls.Add(btnUpdate, 1, 0);
        buttonLayout.Controls.Add(btnDelete, 2, 0);
        buttonLayout.Dock = DockStyle.Fill;
        buttonLayout.Location = new Point(8, 541);
        buttonLayout.Name = "buttonLayout";
        buttonLayout.RowCount = 1;
        buttonLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        buttonLayout.Size = new Size(355, 49);
        buttonLayout.TabIndex = 8;
        // 
        // btnAdd
        // 
        btnAdd.Dock = DockStyle.Fill;
        btnAdd.Location = new Point(3, 3);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(112, 43);
        btnAdd.TabIndex = 0;
        btnAdd.Text = "Thêm mới";
        btnAdd.Click += btnAdd_Click;
        // 
        // btnUpdate
        // 
        btnUpdate.Dock = DockStyle.Fill;
        btnUpdate.Location = new Point(121, 3);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(112, 43);
        btnUpdate.TabIndex = 1;
        btnUpdate.Text = "Cập nhật";
        btnUpdate.Click += btnUpdate_Click;
        // 
        // btnDelete
        // 
        btnDelete.Dock = DockStyle.Fill;
        btnDelete.Location = new Point(239, 3);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(113, 43);
        btnDelete.TabIndex = 2;
        btnDelete.Text = "Xóa";
        btnDelete.Click += btnDelete_Click;
        // 
        // rightLayout
        // 
        rightLayout.ColumnCount = 1;
        rightLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        rightLayout.Controls.Add(searchLayout, 0, 0);
        rightLayout.Controls.Add(dgvProducts, 0, 1);
        rightLayout.Dock = DockStyle.Fill;
        rightLayout.Location = new Point(395, 8);
        rightLayout.Margin = new Padding(8, 0, 0, 0);
        rightLayout.Name = "rightLayout";
        rightLayout.RowCount = 2;
        rightLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
        rightLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        rightLayout.Size = new Size(697, 598);
        rightLayout.TabIndex = 1;
        // 
        // searchLayout
        // 
        searchLayout.ColumnCount = 2;
        searchLayout.ColumnStyles.Add(new ColumnStyle());
        searchLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        searchLayout.Controls.Add(lblSearch, 0, 0);
        searchLayout.Controls.Add(txtSearch, 1, 0);
        searchLayout.Dock = DockStyle.Fill;
        searchLayout.Location = new Point(3, 3);
        searchLayout.Name = "searchLayout";
        searchLayout.RowCount = 1;
        searchLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        searchLayout.Size = new Size(691, 32);
        searchLayout.TabIndex = 0;
        // 
        // lblSearch
        // 
        lblSearch.AutoSize = true;
        lblSearch.Dock = DockStyle.Fill;
        lblSearch.Location = new Point(0, 0);
        lblSearch.Margin = new Padding(0, 0, 8, 0);
        lblSearch.Name = "lblSearch";
        lblSearch.Size = new Size(114, 32);
        lblSearch.TabIndex = 0;
        lblSearch.Text = "Tìm kiếm sản phẩm:";
        lblSearch.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // txtSearch
        // 
        txtSearch.Dock = DockStyle.Fill;
        txtSearch.Location = new Point(125, 5);
        txtSearch.Margin = new Padding(3, 5, 3, 5);
        txtSearch.Name = "txtSearch";
        txtSearch.Size = new Size(563, 23);
        txtSearch.TabIndex = 1;
        txtSearch.TextChanged += txtSearch_TextChanged;
        // 
        // dgvProducts
        // 
        dgvProducts.AllowUserToAddRows = false;
        dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvProducts.Dock = DockStyle.Fill;
        dgvProducts.Location = new Point(3, 41);
        dgvProducts.MultiSelect = false;
        dgvProducts.Name = "dgvProducts";
        dgvProducts.ReadOnly = true;
        dgvProducts.RowHeadersVisible = false;
        dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvProducts.Size = new Size(691, 554);
        dgvProducts.TabIndex = 1;
        dgvProducts.SelectionChanged += dgvProducts_SelectionChanged;
        // 
        // errorProvider
        // 
        errorProvider.ContainerControl = this;
        // 
        // FrmProductManager
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1100, 660);
        Controls.Add(mainLayout);
        Controls.Add(statusStrip1);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        MinimumSize = new Size(900, 600);
        Name = "FrmProductManager";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "TechMart Product Manager";
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        statusStrip1.ResumeLayout(false);
        statusStrip1.PerformLayout();
        mainLayout.ResumeLayout(false);
        leftLayout.ResumeLayout(false);
        leftLayout.PerformLayout();
        inputLayout.ResumeLayout(false);
        inputLayout.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
        buttonLayout.ResumeLayout(false);
        rightLayout.ResumeLayout(false);
        searchLayout.ResumeLayout(false);
        searchLayout.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
        ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

}
