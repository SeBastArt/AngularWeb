using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AngularWeb.Migrations
{
    public partial class Initial_01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "address_company_type",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    created = table.Column<DateTime>(nullable: false),
                    modified = table.Column<DateTime>(nullable: false),
                    created_by = table.Column<long>(nullable: false),
                    modified_by = table.Column<long>(nullable: false),
                    info = table.Column<string>(type: "varchar(max)", nullable: true),
                    info_rtf = table.Column<string>(type: "varchar(max)", nullable: true),
                    name = table.Column<string>(type: "varchar(max)", nullable: true),
                    type = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_address_company_type", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "address_country",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    created = table.Column<DateTime>(nullable: false),
                    modified = table.Column<DateTime>(nullable: false),
                    created_by = table.Column<long>(nullable: false),
                    modified_by = table.Column<long>(nullable: false),
                    info = table.Column<string>(type: "varchar(max)", nullable: true),
                    info_rtf = table.Column<string>(type: "varchar(max)", nullable: true),
                    iso_3cc = table.Column<string>(type: "varchar(3)", nullable: true),
                    iso_2cc = table.Column<string>(type: "varchar(2)", nullable: true),
                    iso_numerical = table.Column<int>(nullable: false),
                    economic_area = table.Column<int>(nullable: false),
                    name = table.Column<string>(type: "varchar(max)", nullable: true),
                    address_type = table.Column<int>(nullable: false),
                    address_text_document_script = table.Column<string>(type: "varchar(max)", nullable: true),
                    address_text_delivery_script = table.Column<string>(type: "varchar(max)", nullable: true),
                    address_text_invoice_script = table.Column<string>(type: "varchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_address_country", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "article_article_text",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    language_iso_3cc = table.Column<string>(type: "varchar(3)", nullable: true),
                    language_iso_2cc = table.Column<string>(type: "varchar(2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_article_article_text", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "article_group",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    created = table.Column<DateTime>(nullable: false),
                    modified = table.Column<DateTime>(nullable: false),
                    created_by = table.Column<long>(nullable: false),
                    modified_by = table.Column<long>(nullable: false),
                    info = table.Column<string>(type: "varchar(max)", nullable: true),
                    info_rtf = table.Column<string>(type: "varchar(max)", nullable: true),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_article_group", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "article_type",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    created = table.Column<DateTime>(nullable: false),
                    modified = table.Column<DateTime>(nullable: false),
                    created_by = table.Column<long>(nullable: false),
                    modified_by = table.Column<long>(nullable: false),
                    info = table.Column<string>(type: "varchar(max)", nullable: true),
                    info_rtf = table.Column<string>(type: "varchar(max)", nullable: true),
                    name = table.Column<string>(nullable: true),
                    nature_type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_article_type", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Audit_WeatherForecast",
                columns: table => new
                {
                    Audit_WeatherForecastId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WeatherForecastId = table.Column<long>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    TemperatureC = table.Column<int>(nullable: false),
                    Summary = table.Column<string>(nullable: true),
                    AuditUser = table.Column<long>(nullable: false),
                    AuditDate = table.Column<DateTime>(nullable: false),
                    AuditAction = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Audit_WeatherForecast", x => x.Audit_WeatherForecastId);
                });

            migrationBuilder.CreateTable(
                name: "fag_binary",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    created = table.Column<DateTime>(nullable: false),
                    modified = table.Column<DateTime>(nullable: false),
                    created_by = table.Column<long>(nullable: false),
                    modified_by = table.Column<long>(nullable: false),
                    info = table.Column<string>(type: "varchar(max)", nullable: true),
                    info_rtf = table.Column<string>(type: "varchar(max)", nullable: true),
                    fk_id = table.Column<long>(nullable: false),
                    file_name = table.Column<string>(type: "varchar(max)", nullable: true),
                    data = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fag_binary", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<byte[]>(nullable: true),
                    PasswordSalt = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "address_address",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    created = table.Column<DateTime>(nullable: false),
                    modified = table.Column<DateTime>(nullable: false),
                    created_by = table.Column<long>(nullable: false),
                    modified_by = table.Column<long>(nullable: false),
                    info = table.Column<string>(type: "varchar(max)", nullable: true),
                    info_rtf = table.Column<string>(type: "varchar(max)", nullable: true),
                    fk_parent_address = table.Column<long>(nullable: true),
                    fk_address_country = table.Column<long>(nullable: true),
                    fk_logo = table.Column<long>(nullable: true),
                    fk_address_company_type = table.Column<long>(nullable: true),
                    name = table.Column<string>(type: "varchar(max)", nullable: true),
                    addition = table.Column<string>(type: "varchar(max)", nullable: true),
                    addition2 = table.Column<string>(type: "varchar(max)", nullable: true),
                    street = table.Column<string>(type: "varchar(max)", nullable: true),
                    postcode = table.Column<string>(type: "varchar(max)", nullable: true),
                    city = table.Column<string>(type: "varchar(max)", nullable: true),
                    email = table.Column<string>(type: "varchar(max)", nullable: true),
                    phone = table.Column<string>(type: "varchar(max)", nullable: true),
                    fax = table.Column<string>(type: "varchar(max)", nullable: true),
                    vat_id_no = table.Column<string>(type: "varchar(max)", nullable: true),
                    timezone = table.Column<string>(type: "varchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_address_address", x => x.id);
                    table.ForeignKey(
                        name: "FK_address_address_address_company_type_fk_address_company_type",
                        column: x => x.fk_address_company_type,
                        principalTable: "address_company_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_address_address_address_country_fk_address_country",
                        column: x => x.fk_address_country,
                        principalTable: "address_country",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_address_address_fag_binary_fk_logo",
                        column: x => x.fk_logo,
                        principalTable: "fag_binary",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_address_address_address_address_fk_parent_address",
                        column: x => x.fk_parent_address,
                        principalTable: "address_address",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "address_person",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    created = table.Column<DateTime>(nullable: false),
                    modified = table.Column<DateTime>(nullable: false),
                    created_by = table.Column<long>(nullable: false),
                    modified_by = table.Column<long>(nullable: false),
                    info = table.Column<string>(type: "varchar(max)", nullable: true),
                    info_rtf = table.Column<string>(type: "varchar(max)", nullable: true),
                    lastname = table.Column<string>(type: "varchar(max)", nullable: true),
                    firstname = table.Column<string>(type: "varchar(max)", nullable: true),
                    sex = table.Column<string>(type: "varchar(max)", nullable: true),
                    department = table.Column<string>(type: "varchar(max)", nullable: true),
                    phone_office = table.Column<string>(type: "varchar(max)", nullable: true),
                    phone_private = table.Column<string>(type: "varchar(max)", nullable: true),
                    email = table.Column<string>(type: "varchar(max)", nullable: true),
                    fk_picture = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_address_person", x => x.id);
                    table.ForeignKey(
                        name: "FK_address_person_fag_binary_fk_picture",
                        column: x => x.fk_picture,
                        principalTable: "fag_binary",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "article_article",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    created = table.Column<DateTime>(nullable: false),
                    modified = table.Column<DateTime>(nullable: false),
                    created_by = table.Column<long>(nullable: false),
                    modified_by = table.Column<long>(nullable: false),
                    info = table.Column<string>(type: "varchar(max)", nullable: true),
                    info_rtf = table.Column<string>(type: "varchar(max)", nullable: true),
                    name = table.Column<string>(nullable: true),
                    material_type = table.Column<int>(nullable: false),
                    is_archived = table.Column<bool>(nullable: false),
                    is_discontinued = table.Column<bool>(nullable: false),
                    is_batch = table.Column<bool>(nullable: false),
                    is_multistock = table.Column<bool>(nullable: false),
                    is_provision_enabled = table.Column<bool>(nullable: false),
                    is_discount_enabled = table.Column<bool>(nullable: false),
                    is_disposition = table.Column<bool>(nullable: false),
                    is_casting = table.Column<bool>(nullable: false),
                    scale_unit_qty = table.Column<int>(nullable: false),
                    scale_unit_type = table.Column<int>(nullable: false),
                    unit_stock = table.Column<int>(nullable: false),
                    unit_stock_in = table.Column<int>(nullable: false),
                    unit_stock_out = table.Column<int>(nullable: false),
                    dim_area = table.Column<int>(nullable: false),
                    dim_length = table.Column<int>(nullable: false),
                    dim_2 = table.Column<int>(nullable: false),
                    dim_3 = table.Column<int>(nullable: false),
                    dim_4 = table.Column<int>(nullable: false),
                    specific_weight = table.Column<decimal>(type: "decimal (38,20)", nullable: false),
                    item_number = table.Column<string>(nullable: true),
                    drawing_number = table.Column<string>(nullable: true),
                    din_norm1 = table.Column<string>(nullable: true),
                    din_norm2 = table.Column<string>(nullable: true),
                    fk_picture_1 = table.Column<long>(nullable: false),
                    fk_picture_2 = table.Column<long>(nullable: false),
                    fk_group = table.Column<long>(nullable: false),
                    fk_type = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_article_article", x => x.id);
                    table.ForeignKey(
                        name: "FK_article_article_article_group_fk_group",
                        column: x => x.fk_group,
                        principalTable: "article_group",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_article_article_article_type_fk_type",
                        column: x => x.fk_type,
                        principalTable: "article_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_article_article_fag_binary_fk_picture_1",
                        column: x => x.fk_picture_1,
                        principalTable: "fag_binary",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_article_article_fag_binary_fk_picture_2",
                        column: x => x.fk_picture_2,
                        principalTable: "fag_binary",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WeatherForecast",
                columns: table => new
                {
                    WeatherForecastId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    created = table.Column<DateTime>(nullable: false),
                    modified = table.Column<DateTime>(nullable: false),
                    created_by = table.Column<long>(nullable: false),
                    modified_by = table.Column<long>(nullable: false),
                    info = table.Column<string>(type: "varchar(max)", nullable: true),
                    info_rtf = table.Column<string>(type: "varchar(max)", nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    TemperatureC = table.Column<int>(nullable: false),
                    summar_y = table.Column<string>(type: "varchar(100)", nullable: true),
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherForecast", x => x.WeatherForecastId);
                    table.ForeignKey(
                        name: "FK_WeatherForecast_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "address_person_relation",
                columns: table => new
                {
                    fk_address = table.Column<long>(nullable: false),
                    fk_person = table.Column<long>(nullable: false),
                    created = table.Column<DateTime>(nullable: false),
                    modified = table.Column<DateTime>(nullable: false),
                    created_by = table.Column<long>(nullable: false),
                    modified_by = table.Column<long>(nullable: false),
                    info = table.Column<string>(type: "varchar(max)", nullable: true),
                    info_rtf = table.Column<string>(type: "varchar(max)", nullable: true),
                    id = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_address_person_relation", x => new { x.fk_address, x.fk_person });
                    table.ForeignKey(
                        name: "FK_address_person_relation_address_address_fk_address",
                        column: x => x.fk_address,
                        principalTable: "address_address",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_address_person_relation_address_person_fk_person",
                        column: x => x.fk_person,
                        principalTable: "address_person",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "document_document",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    created = table.Column<DateTime>(nullable: false),
                    modified = table.Column<DateTime>(nullable: false),
                    created_by = table.Column<long>(nullable: false),
                    modified_by = table.Column<long>(nullable: false),
                    info = table.Column<string>(type: "varchar(max)", nullable: true),
                    info_rtf = table.Column<string>(type: "varchar(max)", nullable: true),
                    DocumentPersonId = table.Column<long>(nullable: false),
                    DocumentAddressId = table.Column<long>(nullable: false),
                    DeliveryPersonId = table.Column<long>(nullable: false),
                    DeliveryAddressId = table.Column<long>(nullable: false),
                    InvoicePersonId = table.Column<long>(nullable: false),
                    InvoiceAddressId = table.Column<long>(nullable: false),
                    address_text_document = table.Column<string>(type: "varchar(max)", nullable: true),
                    address_text_delivery = table.Column<string>(type: "varchar(max)", nullable: true),
                    address_text_invoice = table.Column<string>(type: "varchar(max)", nullable: true),
                    number = table.Column<string>(type: "varchar(max)", nullable: true),
                    type = table.Column<int>(nullable: false),
                    sub_type = table.Column<int>(nullable: false),
                    type_name = table.Column<string>(type: "varchar(max)", nullable: true),
                    value_basis = table.Column<int>(nullable: false),
                    status = table.Column<int>(nullable: false),
                    print_date = table.Column<DateTime>(nullable: false),
                    reminder_date = table.Column<DateTime>(nullable: false),
                    print_count = table.Column<int>(nullable: false),
                    text_start = table.Column<string>(type: "varchar(max)", nullable: true),
                    text_start_rtf = table.Column<string>(type: "varchar(max)", nullable: true),
                    text_head = table.Column<string>(type: "varchar(max)", nullable: true),
                    text_head_rtf = table.Column<string>(type: "varchar(max)", nullable: true),
                    text_paymentterms = table.Column<string>(type: "varchar(max)", nullable: true),
                    text_paymentterms_rtf = table.Column<string>(type: "varchar(max)", nullable: true),
                    text_delivery = table.Column<string>(type: "varchar(max)", nullable: true),
                    text_delivery_rtf = table.Column<string>(type: "varchar(max)", nullable: true),
                    text_end = table.Column<string>(type: "varchar(max)", nullable: true),
                    text_end_rtf = table.Column<string>(type: "varchar(max)", nullable: true),
                    price_sum_net = table.Column<decimal>(type: "decimal (38,20)", nullable: false),
                    price_gross = table.Column<decimal>(type: "decimal (38,20)", nullable: false),
                    is_archive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_document_document", x => x.id);
                    table.ForeignKey(
                        name: "FK_document_document_address_address_DeliveryAddressId",
                        column: x => x.DeliveryAddressId,
                        principalTable: "address_address",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_document_document_address_person_DeliveryPersonId",
                        column: x => x.DeliveryPersonId,
                        principalTable: "address_person",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_document_document_address_address_DocumentAddressId",
                        column: x => x.DocumentAddressId,
                        principalTable: "address_address",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_document_document_address_person_DocumentPersonId",
                        column: x => x.DocumentPersonId,
                        principalTable: "address_person",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_document_document_address_address_InvoiceAddressId",
                        column: x => x.InvoiceAddressId,
                        principalTable: "address_address",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_document_document_address_person_InvoicePersonId",
                        column: x => x.InvoicePersonId,
                        principalTable: "address_person",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "article_places",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    created = table.Column<DateTime>(nullable: false),
                    modified = table.Column<DateTime>(nullable: false),
                    created_by = table.Column<long>(nullable: false),
                    modified_by = table.Column<long>(nullable: false),
                    info = table.Column<string>(type: "varchar(max)", nullable: true),
                    info_rtf = table.Column<string>(type: "varchar(max)", nullable: true),
                    fk_address = table.Column<long>(nullable: false),
                    reserved_qty = table.Column<decimal>(type: "decimal (38,20)", nullable: false),
                    minimum_qty = table.Column<decimal>(type: "decimal (38,20)", nullable: false),
                    opo_qty = table.Column<decimal>(type: "decimal (38,20)", nullable: false),
                    ArticleId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_article_places", x => x.id);
                    table.ForeignKey(
                        name: "FK_article_places_address_address_fk_address",
                        column: x => x.fk_address,
                        principalTable: "address_address",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_article_places_article_article_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "article_article",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "article_pricelist",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    created = table.Column<DateTime>(nullable: false),
                    modified = table.Column<DateTime>(nullable: false),
                    created_by = table.Column<long>(nullable: false),
                    modified_by = table.Column<long>(nullable: false),
                    info = table.Column<string>(type: "varchar(max)", nullable: true),
                    info_rtf = table.Column<string>(type: "varchar(max)", nullable: true),
                    scale_unit_qty = table.Column<int>(nullable: false),
                    scale_unit_type = table.Column<int>(nullable: false),
                    unit_order = table.Column<int>(nullable: false),
                    min_order_qty = table.Column<decimal>(type: "decimal (38,20)", nullable: false),
                    is_multiply_order_qty = table.Column<bool>(nullable: false),
                    fk_article = table.Column<long>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    valid_from = table.Column<DateTime>(nullable: true),
                    valid_to = table.Column<DateTime>(nullable: true),
                    priority = table.Column<long>(nullable: true),
                    reordertime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_article_pricelist", x => x.id);
                    table.ForeignKey(
                        name: "FK_article_pricelist_article_article_fk_article",
                        column: x => x.fk_article,
                        principalTable: "article_article",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_article_pricelist_article_article_fk_article1",
                        column: x => x.fk_article,
                        principalTable: "article_article",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "document_position",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    created = table.Column<DateTime>(nullable: false),
                    modified = table.Column<DateTime>(nullable: false),
                    created_by = table.Column<long>(nullable: false),
                    modified_by = table.Column<long>(nullable: false),
                    info = table.Column<string>(type: "varchar(max)", nullable: true),
                    info_rtf = table.Column<string>(type: "varchar(max)", nullable: true),
                    position_number = table.Column<int>(nullable: false),
                    position_number_text = table.Column<string>(type: "varchar(max)", nullable: true),
                    position_type = table.Column<int>(nullable: false),
                    article_name = table.Column<string>(type: "varchar(max)", nullable: true),
                    article_name_extern = table.Column<string>(type: "varchar(max)", nullable: true),
                    quantitiy = table.Column<decimal>(type: "decimal (38,20)", nullable: false),
                    scale_unit_qty = table.Column<int>(nullable: false),
                    scale_unit_type = table.Column<int>(nullable: false),
                    scale_unit = table.Column<string>(type: "varchar(max)", nullable: true),
                    delivered_quantity = table.Column<decimal>(type: "decimal (38,20)", nullable: false),
                    is_partial_delivery = table.Column<bool>(nullable: false),
                    price_base = table.Column<decimal>(type: "decimal (38,20)", nullable: false),
                    price_per_unit = table.Column<decimal>(type: "decimal (38,20)", nullable: false),
                    price_total = table.Column<decimal>(type: "decimal (38,20)", nullable: false),
                    sales_tax_percent = table.Column<decimal>(type: "decimal (38,20)", nullable: false),
                    ParentId = table.Column<long>(nullable: false),
                    DocumentId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_document_position", x => x.id);
                    table.ForeignKey(
                        name: "FK_document_position_document_document_DocumentId",
                        column: x => x.DocumentId,
                        principalTable: "document_document",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_document_position_document_position_ParentId",
                        column: x => x.ParentId,
                        principalTable: "document_position",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "article_inventory",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    created = table.Column<DateTime>(nullable: false),
                    modified = table.Column<DateTime>(nullable: false),
                    created_by = table.Column<long>(nullable: false),
                    modified_by = table.Column<long>(nullable: false),
                    info = table.Column<string>(type: "varchar(max)", nullable: true),
                    info_rtf = table.Column<string>(type: "varchar(max)", nullable: true),
                    ArticlePlaceId = table.Column<long>(nullable: false),
                    info_1 = table.Column<string>(nullable: true),
                    info_1_rtf = table.Column<string>(nullable: true),
                    info_2 = table.Column<string>(nullable: true),
                    info_2_rtf = table.Column<string>(nullable: true),
                    info_3 = table.Column<string>(nullable: true),
                    info_3_rtf = table.Column<string>(nullable: true),
                    info_4 = table.Column<string>(nullable: true),
                    info_4_rtf = table.Column<string>(nullable: true),
                    info_5 = table.Column<string>(nullable: true),
                    info_5_rtf = table.Column<string>(nullable: true),
                    fk_article = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_article_inventory", x => x.id);
                    table.ForeignKey(
                        name: "FK_article_inventory_article_article_fk_article",
                        column: x => x.fk_article,
                        principalTable: "article_article",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_article_inventory_article_places_ArticlePlaceId",
                        column: x => x.ArticlePlaceId,
                        principalTable: "article_places",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "article_range",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    created = table.Column<DateTime>(nullable: false),
                    modified = table.Column<DateTime>(nullable: false),
                    created_by = table.Column<long>(nullable: false),
                    modified_by = table.Column<long>(nullable: false),
                    info = table.Column<string>(type: "varchar(max)", nullable: true),
                    info_rtf = table.Column<string>(type: "varchar(max)", nullable: true),
                    quantity = table.Column<decimal>(type: "decimal (38,20)", nullable: false),
                    netprice = table.Column<decimal>(type: "decimal (38,20)", nullable: false),
                    discount = table.Column<decimal>(type: "decimal (38,20)", nullable: false),
                    addition = table.Column<decimal>(type: "decimal (38,20)", nullable: false),
                    price = table.Column<decimal>(type: "decimal (38,20)", nullable: false),
                    fk_pricelist = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_article_range", x => x.id);
                    table.ForeignKey(
                        name: "FK_article_range_article_pricelist_fk_pricelist",
                        column: x => x.fk_pricelist,
                        principalTable: "article_pricelist",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "Role", "Username" },
                values: new object[,]
                {
                    { 1L, "Yvette", "Marquardt", new byte[] { 155, 184, 135, 21, 67, 172, 220, 9, 52, 38, 249, 238, 31, 185, 89, 111, 133, 192, 158, 250, 229, 129, 33, 112, 80, 181, 12, 150, 28, 29, 132, 50, 12, 60, 27, 15, 197, 13, 176, 212, 86, 211, 91, 247, 201, 225, 54, 174, 148, 185, 100, 173, 160, 123, 155, 231, 153, 103, 114, 173, 180, 60, 164, 18 }, new byte[] { 69, 108, 242, 36, 195, 239, 180, 2, 104, 213, 127, 132, 190, 14, 220, 215, 128, 92, 172, 23, 221, 98, 147, 55, 17, 236, 43, 202, 61, 181, 29, 102, 210, 31, 139, 149, 140, 231, 191, 0, 134, 208, 252, 96, 226, 78, 250, 117, 197, 234, 1, 195, 159, 184, 8, 243, 205, 123, 75, 27, 56, 202, 147, 201, 13, 44, 120, 158, 151, 144, 169, 154, 12, 26, 124, 195, 190, 178, 200, 71, 184, 176, 233, 118, 101, 24, 32, 67, 100, 19, 233, 56, 14, 157, 110, 251, 219, 223, 249, 109, 114, 188, 92, 57, 19, 19, 149, 50, 92, 166, 126, 71, 208, 15, 13, 231, 171, 42, 150, 7, 74, 227, 198, 48, 220, 224, 221, 218 }, "Admin", "Nigel" },
                    { 2L, "Joelle", "Bergstrom", new byte[] { 155, 184, 135, 21, 67, 172, 220, 9, 52, 38, 249, 238, 31, 185, 89, 111, 133, 192, 158, 250, 229, 129, 33, 112, 80, 181, 12, 150, 28, 29, 132, 50, 12, 60, 27, 15, 197, 13, 176, 212, 86, 211, 91, 247, 201, 225, 54, 174, 148, 185, 100, 173, 160, 123, 155, 231, 153, 103, 114, 173, 180, 60, 164, 18 }, new byte[] { 69, 108, 242, 36, 195, 239, 180, 2, 104, 213, 127, 132, 190, 14, 220, 215, 128, 92, 172, 23, 221, 98, 147, 55, 17, 236, 43, 202, 61, 181, 29, 102, 210, 31, 139, 149, 140, 231, 191, 0, 134, 208, 252, 96, 226, 78, 250, 117, 197, 234, 1, 195, 159, 184, 8, 243, 205, 123, 75, 27, 56, 202, 147, 201, 13, 44, 120, 158, 151, 144, 169, 154, 12, 26, 124, 195, 190, 178, 200, 71, 184, 176, 233, 118, 101, 24, 32, 67, 100, 19, 233, 56, 14, 157, 110, 251, 219, 223, 249, 109, 114, 188, 92, 57, 19, 19, 149, 50, 92, 166, 126, 71, 208, 15, 13, 231, 171, 42, 150, 7, 74, 227, 198, 48, 220, 224, 221, 218 }, "Admin", "Travis" },
                    { 3L, "Madisyn", "McCullough", new byte[] { 155, 184, 135, 21, 67, 172, 220, 9, 52, 38, 249, 238, 31, 185, 89, 111, 133, 192, 158, 250, 229, 129, 33, 112, 80, 181, 12, 150, 28, 29, 132, 50, 12, 60, 27, 15, 197, 13, 176, 212, 86, 211, 91, 247, 201, 225, 54, 174, 148, 185, 100, 173, 160, 123, 155, 231, 153, 103, 114, 173, 180, 60, 164, 18 }, new byte[] { 69, 108, 242, 36, 195, 239, 180, 2, 104, 213, 127, 132, 190, 14, 220, 215, 128, 92, 172, 23, 221, 98, 147, 55, 17, 236, 43, 202, 61, 181, 29, 102, 210, 31, 139, 149, 140, 231, 191, 0, 134, 208, 252, 96, 226, 78, 250, 117, 197, 234, 1, 195, 159, 184, 8, 243, 205, 123, 75, 27, 56, 202, 147, 201, 13, 44, 120, 158, 151, 144, 169, 154, 12, 26, 124, 195, 190, 178, 200, 71, 184, 176, 233, 118, 101, 24, 32, 67, 100, 19, 233, 56, 14, 157, 110, 251, 219, 223, 249, 109, 114, 188, 92, 57, 19, 19, 149, 50, 92, 166, 126, 71, 208, 15, 13, 231, 171, 42, 150, 7, 74, 227, 198, 48, 220, 224, 221, 218 }, "Admin", "Coralie" },
                    { 4L, "Donna", "Leannon", new byte[] { 155, 184, 135, 21, 67, 172, 220, 9, 52, 38, 249, 238, 31, 185, 89, 111, 133, 192, 158, 250, 229, 129, 33, 112, 80, 181, 12, 150, 28, 29, 132, 50, 12, 60, 27, 15, 197, 13, 176, 212, 86, 211, 91, 247, 201, 225, 54, 174, 148, 185, 100, 173, 160, 123, 155, 231, 153, 103, 114, 173, 180, 60, 164, 18 }, new byte[] { 69, 108, 242, 36, 195, 239, 180, 2, 104, 213, 127, 132, 190, 14, 220, 215, 128, 92, 172, 23, 221, 98, 147, 55, 17, 236, 43, 202, 61, 181, 29, 102, 210, 31, 139, 149, 140, 231, 191, 0, 134, 208, 252, 96, 226, 78, 250, 117, 197, 234, 1, 195, 159, 184, 8, 243, 205, 123, 75, 27, 56, 202, 147, 201, 13, 44, 120, 158, 151, 144, 169, 154, 12, 26, 124, 195, 190, 178, 200, 71, 184, 176, 233, 118, 101, 24, 32, 67, 100, 19, 233, 56, 14, 157, 110, 251, 219, 223, 249, 109, 114, 188, 92, 57, 19, 19, 149, 50, 92, 166, 126, 71, 208, 15, 13, 231, 171, 42, 150, 7, 74, 227, 198, 48, 220, 224, 221, 218 }, "Admin", "Yesenia" },
                    { 5L, "Sebastian", "Schüler", new byte[] { 155, 184, 135, 21, 67, 172, 220, 9, 52, 38, 249, 238, 31, 185, 89, 111, 133, 192, 158, 250, 229, 129, 33, 112, 80, 181, 12, 150, 28, 29, 132, 50, 12, 60, 27, 15, 197, 13, 176, 212, 86, 211, 91, 247, 201, 225, 54, 174, 148, 185, 100, 173, 160, 123, 155, 231, 153, 103, 114, 173, 180, 60, 164, 18 }, new byte[] { 69, 108, 242, 36, 195, 239, 180, 2, 104, 213, 127, 132, 190, 14, 220, 215, 128, 92, 172, 23, 221, 98, 147, 55, 17, 236, 43, 202, 61, 181, 29, 102, 210, 31, 139, 149, 140, 231, 191, 0, 134, 208, 252, 96, 226, 78, 250, 117, 197, 234, 1, 195, 159, 184, 8, 243, 205, 123, 75, 27, 56, 202, 147, 201, 13, 44, 120, 158, 151, 144, 169, 154, 12, 26, 124, 195, 190, 178, 200, 71, 184, 176, 233, 118, 101, 24, 32, 67, 100, 19, 233, 56, 14, 157, 110, 251, 219, 223, 249, 109, 114, 188, 92, 57, 19, 19, 149, 50, 92, 166, 126, 71, 208, 15, 13, 231, 171, 42, 150, 7, 74, 227, 198, 48, 220, 224, 221, 218 }, "Admin", "user" }
                });

            migrationBuilder.InsertData(
                table: "WeatherForecast",
                columns: new[] { "WeatherForecastId", "created", "created_by", "Date", "info", "info_rtf", "modified", "modified_by", "summar_y", "TemperatureC", "UserId" },
                values: new object[,]
                {
                    { 3L, new DateTime(2020, 3, 12, 15, 45, 26, 792, DateTimeKind.Utc).AddTicks(5928), 1L, new DateTime(2020, 7, 31, 19, 30, 23, 876, DateTimeKind.Local).AddTicks(6229), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 792, DateTimeKind.Utc).AddTicks(5946), 5L, "orchid", 5, 1L },
                    { 69L, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(9666), 2L, new DateTime(2021, 1, 8, 17, 11, 33, 156, DateTimeKind.Local).AddTicks(244), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(9670), 3L, "Corporate", -14, 4L },
                    { 64L, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(9331), 2L, new DateTime(2020, 7, 1, 6, 23, 21, 749, DateTimeKind.Local).AddTicks(179), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(9335), 2L, "input", 1, 4L },
                    { 62L, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(9226), 2L, new DateTime(2020, 8, 23, 19, 47, 36, 710, DateTimeKind.Local).AddTicks(9497), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(9230), 2L, "cultivate", -12, 4L },
                    { 59L, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(9063), 1L, new DateTime(2020, 10, 3, 18, 32, 9, 568, DateTimeKind.Local).AddTicks(2366), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(9068), 1L, "scale", -15, 4L },
                    { 54L, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(8759), 2L, new DateTime(2020, 5, 25, 17, 58, 47, 610, DateTimeKind.Local).AddTicks(7277), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(8763), 5L, "Internal", 11, 4L },
                    { 41L, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(3160), 2L, new DateTime(2021, 1, 8, 1, 27, 1, 276, DateTimeKind.Local).AddTicks(2540), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(3165), 4L, "Metal", -1, 4L },
                    { 39L, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(2158), 4L, new DateTime(2021, 2, 22, 14, 27, 41, 545, DateTimeKind.Local).AddTicks(5504), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(2161), 4L, "calculating", 9, 4L },
                    { 36L, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(1963), 1L, new DateTime(2020, 10, 8, 23, 11, 46, 256, DateTimeKind.Local).AddTicks(8627), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(1967), 1L, "Mobility", 4, 4L },
                    { 24L, new DateTime(2020, 3, 12, 15, 45, 26, 798, DateTimeKind.Utc).AddTicks(5818), 2L, new DateTime(2020, 9, 28, 23, 13, 41, 966, DateTimeKind.Local).AddTicks(1380), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 798, DateTimeKind.Utc).AddTicks(5824), 3L, "backing up", -13, 4L },
                    { 17L, new DateTime(2020, 3, 12, 15, 45, 26, 797, DateTimeKind.Utc).AddTicks(2042), 4L, new DateTime(2020, 4, 19, 12, 32, 13, 334, DateTimeKind.Local).AddTicks(8056), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 797, DateTimeKind.Utc).AddTicks(2046), 5L, "open-source", -9, 4L },
                    { 16L, new DateTime(2020, 3, 12, 15, 45, 26, 797, DateTimeKind.Utc).AddTicks(1937), 3L, new DateTime(2020, 12, 7, 22, 33, 24, 946, DateTimeKind.Local).AddTicks(8788), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 797, DateTimeKind.Utc).AddTicks(1943), 4L, "Planner", 14, 4L },
                    { 15L, new DateTime(2020, 3, 12, 15, 45, 26, 796, DateTimeKind.Utc).AddTicks(9518), 1L, new DateTime(2020, 4, 9, 3, 48, 16, 768, DateTimeKind.Local).AddTicks(1786), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 796, DateTimeKind.Utc).AddTicks(9522), 1L, "national", -9, 4L },
                    { 1L, new DateTime(2020, 3, 12, 15, 45, 26, 790, DateTimeKind.Utc).AddTicks(4640), 4L, new DateTime(2020, 12, 23, 8, 56, 40, 283, DateTimeKind.Local).AddTicks(1087), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 790, DateTimeKind.Utc).AddTicks(7898), 4L, "Danish Krone", 15, 4L },
                    { 97L, new DateTime(2020, 3, 12, 15, 45, 26, 801, DateTimeKind.Utc).AddTicks(8279), 5L, new DateTime(2021, 2, 10, 21, 6, 4, 668, DateTimeKind.Local).AddTicks(5260), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 801, DateTimeKind.Utc).AddTicks(8288), 4L, "Cayman Islands", 13, 3L },
                    { 95L, new DateTime(2020, 3, 12, 15, 45, 26, 801, DateTimeKind.Utc).AddTicks(4871), 5L, new DateTime(2021, 1, 26, 6, 12, 8, 779, DateTimeKind.Local).AddTicks(8489), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 801, DateTimeKind.Utc).AddTicks(4878), 4L, "web-enabled", -12, 3L },
                    { 94L, new DateTime(2020, 3, 12, 15, 45, 26, 801, DateTimeKind.Utc).AddTicks(4766), 1L, new DateTime(2021, 2, 17, 14, 0, 14, 823, DateTimeKind.Local).AddTicks(858), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 801, DateTimeKind.Utc).AddTicks(4774), 4L, "Centralized", 11, 3L },
                    { 89L, new DateTime(2020, 3, 12, 15, 45, 26, 801, DateTimeKind.Utc).AddTicks(4166), 1L, new DateTime(2020, 11, 15, 19, 33, 18, 197, DateTimeKind.Local).AddTicks(5649), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 801, DateTimeKind.Utc).AddTicks(4173), 5L, "District", -13, 3L },
                    { 87L, new DateTime(2020, 3, 12, 15, 45, 26, 801, DateTimeKind.Utc).AddTicks(3934), 4L, new DateTime(2020, 10, 7, 17, 32, 39, 368, DateTimeKind.Local).AddTicks(2848), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 801, DateTimeKind.Utc).AddTicks(3941), 5L, "world-class", 15, 3L },
                    { 83L, new DateTime(2020, 3, 12, 15, 45, 26, 800, DateTimeKind.Utc).AddTicks(6221), 1L, new DateTime(2020, 11, 28, 10, 22, 28, 805, DateTimeKind.Local).AddTicks(4676), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 800, DateTimeKind.Utc).AddTicks(6228), 1L, "open-source", 12, 3L },
                    { 78L, new DateTime(2020, 3, 12, 15, 45, 26, 800, DateTimeKind.Utc).AddTicks(5668), 5L, new DateTime(2020, 12, 30, 9, 9, 19, 931, DateTimeKind.Local).AddTicks(2467), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 800, DateTimeKind.Utc).AddTicks(5676), 1L, "wireless", -14, 3L },
                    { 77L, new DateTime(2020, 3, 12, 15, 45, 26, 800, DateTimeKind.Utc).AddTicks(5469), 1L, new DateTime(2021, 1, 11, 15, 43, 27, 998, DateTimeKind.Local).AddTicks(1324), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 800, DateTimeKind.Utc).AddTicks(5482), 2L, "Square", 7, 3L },
                    { 71L, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(9797), 2L, new DateTime(2021, 2, 17, 13, 22, 54, 522, DateTimeKind.Local).AddTicks(3346), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(9801), 4L, "connecting", 4, 4L },
                    { 73L, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(9903), 1L, new DateTime(2020, 12, 2, 6, 18, 10, 975, DateTimeKind.Local).AddTicks(3433), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(9907), 5L, "scale", 6, 3L },
                    { 72L, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(9851), 5L, new DateTime(2020, 10, 2, 22, 57, 31, 248, DateTimeKind.Local).AddTicks(864), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(9855), 5L, "Gorgeous", -2, 4L },
                    { 76L, new DateTime(2020, 3, 12, 15, 45, 26, 800, DateTimeKind.Utc).AddTicks(234), 1L, new DateTime(2020, 7, 17, 2, 22, 34, 546, DateTimeKind.Local).AddTicks(5496), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 800, DateTimeKind.Utc).AddTicks(241), 4L, "Officer", 7, 4L },
                    { 96L, new DateTime(2020, 3, 12, 15, 45, 26, 801, DateTimeKind.Utc).AddTicks(4977), 1L, new DateTime(2020, 4, 26, 15, 52, 26, 203, DateTimeKind.Local).AddTicks(1746), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 801, DateTimeKind.Utc).AddTicks(4984), 4L, "Credit Card Account", -12, 5L },
                    { 81L, new DateTime(2020, 3, 12, 15, 45, 26, 800, DateTimeKind.Utc).AddTicks(6012), 1L, new DateTime(2021, 1, 8, 1, 20, 2, 385, DateTimeKind.Local).AddTicks(2235), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 800, DateTimeKind.Utc).AddTicks(6020), 5L, "Maine", -3, 5L },
                    { 66L, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(9502), 1L, new DateTime(2020, 8, 28, 22, 4, 36, 527, DateTimeKind.Local).AddTicks(9935), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(9506), 5L, "Lead", 4, 5L },
                    { 65L, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(9444), 5L, new DateTime(2020, 6, 12, 8, 0, 14, 740, DateTimeKind.Local).AddTicks(5553), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(9448), 4L, "Movies & Clothing", -3, 5L },
                    { 63L, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(9279), 1L, new DateTime(2020, 7, 22, 7, 18, 41, 143, DateTimeKind.Local).AddTicks(3211), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(9283), 4L, "Advanced", 14, 5L },
                    { 55L, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(8827), 2L, new DateTime(2020, 3, 19, 11, 8, 43, 592, DateTimeKind.Local).AddTicks(542), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(8831), 4L, "Guarani", -6, 5L },
                    { 52L, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(8653), 2L, new DateTime(2020, 9, 6, 14, 44, 42, 118, DateTimeKind.Local).AddTicks(3353), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(8657), 4L, "Brand", 0, 5L },
                    { 44L, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(3772), 3L, new DateTime(2020, 5, 7, 6, 13, 16, 359, DateTimeKind.Local).AddTicks(2690), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(3776), 5L, "Tunisian Dinar", -3, 5L },
                    { 42L, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(3593), 5L, new DateTime(2020, 7, 18, 6, 6, 25, 887, DateTimeKind.Local).AddTicks(9699), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(3598), 5L, "Baby, Beauty & Games", -4, 5L },
                    { 40L, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(2211), 5L, new DateTime(2020, 8, 12, 16, 18, 13, 630, DateTimeKind.Local).AddTicks(4068), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(2215), 2L, "auxiliary", -10, 5L },
                    { 33L, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(1743), 5L, new DateTime(2020, 3, 25, 4, 45, 35, 646, DateTimeKind.Local).AddTicks(7371), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(1750), 5L, "Principal", 3, 5L },
                    { 28L, new DateTime(2020, 3, 12, 15, 45, 26, 798, DateTimeKind.Utc).AddTicks(6146), 3L, new DateTime(2020, 8, 24, 17, 15, 53, 157, DateTimeKind.Local).AddTicks(6476), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 798, DateTimeKind.Utc).AddTicks(6150), 1L, "Self-enabling", 10, 5L },
                    { 26L, new DateTime(2020, 3, 12, 15, 45, 26, 798, DateTimeKind.Utc).AddTicks(6028), 3L, new DateTime(2020, 5, 23, 9, 13, 12, 128, DateTimeKind.Local).AddTicks(2668), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 798, DateTimeKind.Utc).AddTicks(6032), 5L, "Practical Metal Hat", -12, 5L },
                    { 22L, new DateTime(2020, 3, 12, 15, 45, 26, 798, DateTimeKind.Utc).AddTicks(1491), 2L, new DateTime(2021, 1, 2, 20, 45, 5, 796, DateTimeKind.Local).AddTicks(9267), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 798, DateTimeKind.Utc).AddTicks(1496), 4L, "Technician", 3, 5L },
                    { 20L, new DateTime(2020, 3, 12, 15, 45, 26, 797, DateTimeKind.Utc).AddTicks(8468), 2L, new DateTime(2020, 11, 30, 18, 32, 48, 279, DateTimeKind.Local).AddTicks(2579), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 797, DateTimeKind.Utc).AddTicks(8475), 4L, "Kids, Electronics & Movies", 5, 5L },
                    { 11L, new DateTime(2020, 3, 12, 15, 45, 26, 796, DateTimeKind.Utc).AddTicks(6314), 1L, new DateTime(2020, 3, 13, 6, 59, 19, 434, DateTimeKind.Local).AddTicks(2704), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 796, DateTimeKind.Utc).AddTicks(6321), 1L, "Handmade Plastic Towels", -7, 5L },
                    { 5L, new DateTime(2020, 3, 12, 15, 45, 26, 793, DateTimeKind.Utc).AddTicks(5470), 2L, new DateTime(2021, 2, 21, 12, 37, 31, 189, DateTimeKind.Local).AddTicks(1606), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 793, DateTimeKind.Utc).AddTicks(5481), 3L, "sexy", -14, 5L },
                    { 93L, new DateTime(2020, 3, 12, 15, 45, 26, 801, DateTimeKind.Utc).AddTicks(4664), 3L, new DateTime(2020, 8, 1, 11, 47, 13, 844, DateTimeKind.Local).AddTicks(6349), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 801, DateTimeKind.Utc).AddTicks(4672), 3L, "Latvian Lats", -6, 4L },
                    { 88L, new DateTime(2020, 3, 12, 15, 45, 26, 801, DateTimeKind.Utc).AddTicks(4044), 5L, new DateTime(2021, 1, 23, 8, 38, 25, 818, DateTimeKind.Local).AddTicks(7051), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 801, DateTimeKind.Utc).AddTicks(4051), 2L, "Triple-buffered", 10, 4L },
                    { 86L, new DateTime(2020, 3, 12, 15, 45, 26, 801, DateTimeKind.Utc).AddTicks(3825), 1L, new DateTime(2020, 9, 29, 16, 59, 22, 543, DateTimeKind.Local).AddTicks(8993), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 801, DateTimeKind.Utc).AddTicks(3832), 5L, "Walks", 8, 4L },
                    { 82L, new DateTime(2020, 3, 12, 15, 45, 26, 800, DateTimeKind.Utc).AddTicks(6117), 3L, new DateTime(2020, 5, 30, 16, 33, 13, 435, DateTimeKind.Local).AddTicks(1234), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 800, DateTimeKind.Utc).AddTicks(6124), 2L, "AI", 8, 4L },
                    { 74L, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(9958), 5L, new DateTime(2020, 6, 1, 2, 10, 9, 508, DateTimeKind.Local).AddTicks(4032), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(9962), 5L, "olive", 4, 4L },
                    { 68L, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(9614), 1L, new DateTime(2020, 9, 30, 16, 55, 51, 564, DateTimeKind.Local).AddTicks(630), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(9618), 5L, "real-time", 2, 3L },
                    { 61L, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(9174), 3L, new DateTime(2020, 7, 22, 18, 40, 18, 440, DateTimeKind.Local).AddTicks(9132), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(9178), 2L, "SMS", -14, 3L },
                    { 58L, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(8989), 3L, new DateTime(2021, 3, 12, 14, 47, 28, 11, DateTimeKind.Local).AddTicks(6957), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(8992), 4L, "index", 14, 3L },
                    { 27L, new DateTime(2020, 3, 12, 15, 45, 26, 798, DateTimeKind.Utc).AddTicks(6089), 2L, new DateTime(2020, 7, 8, 18, 49, 9, 992, DateTimeKind.Local).AddTicks(6661), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 798, DateTimeKind.Utc).AddTicks(6093), 3L, "1080p", 10, 2L },
                    { 14L, new DateTime(2020, 3, 12, 15, 45, 26, 796, DateTimeKind.Utc).AddTicks(9455), 3L, new DateTime(2021, 2, 24, 1, 31, 53, 719, DateTimeKind.Local).AddTicks(7353), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 796, DateTimeKind.Utc).AddTicks(9459), 3L, "Customer-focused", -8, 2L },
                    { 12L, new DateTime(2020, 3, 12, 15, 45, 26, 796, DateTimeKind.Utc).AddTicks(9274), 2L, new DateTime(2020, 3, 27, 14, 10, 40, 330, DateTimeKind.Local).AddTicks(6913), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 796, DateTimeKind.Utc).AddTicks(9281), 1L, "Assurance", 10, 2L },
                    { 10L, new DateTime(2020, 3, 12, 15, 45, 26, 796, DateTimeKind.Utc).AddTicks(610), 4L, new DateTime(2020, 5, 20, 12, 51, 16, 816, DateTimeKind.Local).AddTicks(8147), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 796, DateTimeKind.Utc).AddTicks(617), 5L, "hard drive", 15, 2L },
                    { 7L, new DateTime(2020, 3, 12, 15, 45, 26, 794, DateTimeKind.Utc).AddTicks(3593), 4L, new DateTime(2020, 4, 14, 4, 48, 47, 901, DateTimeKind.Local).AddTicks(7905), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 794, DateTimeKind.Utc).AddTicks(3601), 3L, "Fully-configurable", -3, 2L },
                    { 4L, new DateTime(2020, 3, 12, 15, 45, 26, 792, DateTimeKind.Utc).AddTicks(9847), 3L, new DateTime(2020, 6, 1, 11, 41, 13, 835, DateTimeKind.Local).AddTicks(5654), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 792, DateTimeKind.Utc).AddTicks(9857), 1L, "Practical", -3, 2L },
                    { 100L, new DateTime(2020, 3, 12, 15, 45, 26, 802, DateTimeKind.Utc).AddTicks(1844), 1L, new DateTime(2020, 10, 7, 13, 52, 28, 614, DateTimeKind.Local).AddTicks(1311), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 802, DateTimeKind.Utc).AddTicks(1851), 5L, "Tasty Rubber Keyboard", 0, 1L },
                    { 92L, new DateTime(2020, 3, 12, 15, 45, 26, 801, DateTimeKind.Utc).AddTicks(4537), 1L, new DateTime(2021, 1, 26, 3, 7, 22, 781, DateTimeKind.Local).AddTicks(8041), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 801, DateTimeKind.Utc).AddTicks(4543), 2L, "parse", 10, 1L },
                    { 91L, new DateTime(2020, 3, 12, 15, 45, 26, 801, DateTimeKind.Utc).AddTicks(4433), 1L, new DateTime(2020, 6, 5, 23, 47, 20, 578, DateTimeKind.Local).AddTicks(496), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 801, DateTimeKind.Utc).AddTicks(4441), 5L, "driver", -10, 1L },
                    { 90L, new DateTime(2020, 3, 12, 15, 45, 26, 801, DateTimeKind.Utc).AddTicks(4325), 2L, new DateTime(2020, 11, 29, 11, 46, 2, 79, DateTimeKind.Local).AddTicks(5506), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 801, DateTimeKind.Utc).AddTicks(4334), 2L, "Small Cotton Keyboard", 2, 1L },
                    { 84L, new DateTime(2020, 3, 12, 15, 45, 26, 800, DateTimeKind.Utc).AddTicks(9958), 4L, new DateTime(2020, 7, 30, 14, 16, 26, 431, DateTimeKind.Local).AddTicks(494), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 800, DateTimeKind.Utc).AddTicks(9967), 5L, "Berkshire", -11, 1L },
                    { 75L, new DateTime(2020, 3, 12, 15, 45, 26, 800, DateTimeKind.Utc).AddTicks(29), 3L, new DateTime(2020, 4, 6, 23, 46, 3, 736, DateTimeKind.Local).AddTicks(3505), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 800, DateTimeKind.Utc).AddTicks(36), 1L, "Pre-emptive", -3, 1L },
                    { 60L, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(9119), 5L, new DateTime(2021, 2, 17, 14, 29, 41, 262, DateTimeKind.Local).AddTicks(1532), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(9123), 2L, "supply-chains", -8, 1L },
                    { 57L, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(8936), 3L, new DateTime(2020, 6, 20, 2, 23, 43, 18, DateTimeKind.Local).AddTicks(7550), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(8940), 3L, "online", 4, 1L },
                    { 56L, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(8881), 5L, new DateTime(2020, 7, 1, 9, 48, 22, 997, DateTimeKind.Local).AddTicks(2831), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(8884), 3L, "Central", 8, 1L },
                    { 51L, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(8599), 1L, new DateTime(2021, 2, 21, 22, 39, 37, 746, DateTimeKind.Local).AddTicks(4810), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(8603), 5L, "Implementation", 0, 1L },
                    { 49L, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(8442), 3L, new DateTime(2021, 2, 28, 7, 47, 28, 38, DateTimeKind.Local).AddTicks(6356), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(8447), 2L, "Trafficway", 15, 1L },
                    { 37L, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(2023), 2L, new DateTime(2020, 10, 12, 10, 12, 1, 993, DateTimeKind.Local).AddTicks(2867), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(2026), 3L, "cyan", -4, 1L },
                    { 30L, new DateTime(2020, 3, 12, 15, 45, 26, 798, DateTimeKind.Utc).AddTicks(8563), 5L, new DateTime(2020, 4, 13, 14, 33, 40, 712, DateTimeKind.Local).AddTicks(4239), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 798, DateTimeKind.Utc).AddTicks(8567), 1L, "connecting", -8, 1L },
                    { 29L, new DateTime(2020, 3, 12, 15, 45, 26, 798, DateTimeKind.Utc).AddTicks(8466), 3L, new DateTime(2020, 7, 15, 20, 42, 0, 953, DateTimeKind.Local).AddTicks(8034), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 798, DateTimeKind.Utc).AddTicks(8472), 3L, "Credit Card Account", 0, 1L },
                    { 25L, new DateTime(2020, 3, 12, 15, 45, 26, 798, DateTimeKind.Utc).AddTicks(5919), 4L, new DateTime(2020, 10, 10, 22, 28, 44, 768, DateTimeKind.Local).AddTicks(1867), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 798, DateTimeKind.Utc).AddTicks(5923), 3L, "Delaware", -1, 1L },
                    { 31L, new DateTime(2020, 3, 12, 15, 45, 26, 798, DateTimeKind.Utc).AddTicks(8649), 4L, new DateTime(2021, 2, 2, 23, 36, 28, 64, DateTimeKind.Local).AddTicks(6682), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 798, DateTimeKind.Utc).AddTicks(8653), 1L, "Incredible Wooden Shoes", -8, 2L },
                    { 32L, new DateTime(2020, 3, 12, 15, 45, 26, 798, DateTimeKind.Utc).AddTicks(9636), 2L, new DateTime(2020, 7, 17, 20, 14, 1, 321, DateTimeKind.Local).AddTicks(5503), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 798, DateTimeKind.Utc).AddTicks(9642), 4L, "Rustic Steel Pants", 13, 2L },
                    { 34L, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(1843), 2L, new DateTime(2021, 2, 26, 6, 19, 58, 963, DateTimeKind.Local).AddTicks(8125), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(1848), 2L, "e-markets", -11, 2L },
                    { 38L, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(2100), 3L, new DateTime(2020, 7, 13, 3, 26, 57, 450, DateTimeKind.Local).AddTicks(4792), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(2104), 4L, "Intelligent Concrete Shoes", 14, 2L },
                    { 53L, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(8705), 3L, new DateTime(2020, 3, 20, 3, 13, 24, 744, DateTimeKind.Local).AddTicks(6243), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(8709), 5L, "Identity", -14, 3L },
                    { 50L, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(8539), 5L, new DateTime(2020, 8, 19, 12, 19, 58, 985, DateTimeKind.Local).AddTicks(6146), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(8543), 2L, "Direct", 3, 3L },
                    { 48L, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(6372), 1L, new DateTime(2020, 8, 22, 13, 3, 41, 148, DateTimeKind.Local).AddTicks(1631), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(6376), 5L, "Brazilian Real", -6, 3L },
                    { 47L, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(6302), 4L, new DateTime(2020, 4, 16, 1, 13, 4, 58, DateTimeKind.Local).AddTicks(3801), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(6307), 4L, "fuchsia", -3, 3L },
                    { 45L, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(6147), 3L, new DateTime(2021, 1, 7, 2, 8, 38, 401, DateTimeKind.Local).AddTicks(895), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(6154), 2L, "bypass", 14, 3L },
                    { 35L, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(1904), 2L, new DateTime(2020, 5, 14, 17, 38, 45, 741, DateTimeKind.Local).AddTicks(5656), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(1908), 2L, "efficient", -1, 3L },
                    { 23L, new DateTime(2020, 3, 12, 15, 45, 26, 798, DateTimeKind.Utc).AddTicks(3684), 3L, new DateTime(2021, 2, 6, 3, 17, 38, 623, DateTimeKind.Local).AddTicks(8177), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 798, DateTimeKind.Utc).AddTicks(3690), 1L, "COM", -8, 3L },
                    { 21L, new DateTime(2020, 3, 12, 15, 45, 26, 798, DateTimeKind.Utc).AddTicks(1332), 5L, new DateTime(2020, 3, 26, 21, 8, 28, 534, DateTimeKind.Local).AddTicks(5819), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 798, DateTimeKind.Utc).AddTicks(1338), 5L, "reinvent", 12, 3L },
                    { 19L, new DateTime(2020, 3, 12, 15, 45, 26, 797, DateTimeKind.Utc).AddTicks(4513), 3L, new DateTime(2020, 10, 13, 7, 20, 23, 557, DateTimeKind.Local).AddTicks(4684), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 797, DateTimeKind.Utc).AddTicks(4518), 4L, "paradigms", -14, 3L },
                    { 18L, new DateTime(2020, 3, 12, 15, 45, 26, 797, DateTimeKind.Utc).AddTicks(4409), 2L, new DateTime(2020, 8, 17, 19, 29, 36, 400, DateTimeKind.Local).AddTicks(1809), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 797, DateTimeKind.Utc).AddTicks(4415), 3L, "niches", -4, 3L },
                    { 98L, new DateTime(2020, 3, 12, 15, 45, 26, 802, DateTimeKind.Utc).AddTicks(1519), 4L, new DateTime(2020, 8, 13, 18, 57, 51, 136, DateTimeKind.Local).AddTicks(7274), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 802, DateTimeKind.Utc).AddTicks(1528), 2L, "withdrawal", 8, 5L },
                    { 13L, new DateTime(2020, 3, 12, 15, 45, 26, 796, DateTimeKind.Utc).AddTicks(9388), 4L, new DateTime(2020, 7, 16, 14, 16, 52, 695, DateTimeKind.Local).AddTicks(3337), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 796, DateTimeKind.Utc).AddTicks(9393), 5L, "mobile", 6, 3L },
                    { 8L, new DateTime(2020, 3, 12, 15, 45, 26, 795, DateTimeKind.Utc).AddTicks(4221), 3L, new DateTime(2020, 6, 9, 15, 7, 43, 861, DateTimeKind.Local).AddTicks(6923), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 795, DateTimeKind.Utc).AddTicks(4229), 3L, "Jewelery", -15, 3L },
                    { 6L, new DateTime(2020, 3, 12, 15, 45, 26, 794, DateTimeKind.Utc).AddTicks(69), 4L, new DateTime(2020, 7, 5, 17, 48, 1, 938, DateTimeKind.Local).AddTicks(1852), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 794, DateTimeKind.Utc).AddTicks(82), 3L, "even-keeled", 14, 3L },
                    { 2L, new DateTime(2020, 3, 12, 15, 45, 26, 792, DateTimeKind.Utc).AddTicks(232), 3L, new DateTime(2020, 11, 15, 15, 18, 21, 121, DateTimeKind.Local).AddTicks(8491), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 792, DateTimeKind.Utc).AddTicks(315), 5L, "haptic", -6, 3L },
                    { 85L, new DateTime(2020, 3, 12, 15, 45, 26, 801, DateTimeKind.Utc).AddTicks(3658), 2L, new DateTime(2020, 5, 10, 16, 45, 35, 515, DateTimeKind.Local).AddTicks(1305), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 801, DateTimeKind.Utc).AddTicks(3667), 4L, "conglomeration", 10, 2L },
                    { 80L, new DateTime(2020, 3, 12, 15, 45, 26, 800, DateTimeKind.Utc).AddTicks(5895), 4L, new DateTime(2020, 10, 24, 10, 54, 50, 19, DateTimeKind.Local).AddTicks(8111), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 800, DateTimeKind.Utc).AddTicks(5903), 5L, "Investment Account", 12, 2L },
                    { 79L, new DateTime(2020, 3, 12, 15, 45, 26, 800, DateTimeKind.Utc).AddTicks(5786), 5L, new DateTime(2021, 1, 26, 23, 3, 14, 974, DateTimeKind.Local).AddTicks(3539), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 800, DateTimeKind.Utc).AddTicks(5794), 1L, "SMS", 4, 2L },
                    { 70L, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(9743), 3L, new DateTime(2020, 9, 25, 4, 50, 25, 138, DateTimeKind.Local).AddTicks(3065), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(9747), 5L, "Small Cotton Car", -4, 2L },
                    { 67L, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(9559), 1L, new DateTime(2021, 1, 17, 4, 22, 8, 556, DateTimeKind.Local).AddTicks(3411), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(9562), 3L, "Agent", -12, 2L },
                    { 46L, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(6245), 1L, new DateTime(2021, 1, 1, 7, 18, 12, 975, DateTimeKind.Local).AddTicks(5581), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(6249), 3L, "networks", 13, 2L },
                    { 43L, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(3691), 2L, new DateTime(2020, 3, 20, 8, 34, 30, 354, DateTimeKind.Local).AddTicks(3795), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 799, DateTimeKind.Utc).AddTicks(3695), 4L, "Incredible Frozen Cheese", 15, 2L },
                    { 9L, new DateTime(2020, 3, 12, 15, 45, 26, 795, DateTimeKind.Utc).AddTicks(7970), 2L, new DateTime(2020, 5, 12, 17, 5, 44, 919, DateTimeKind.Local).AddTicks(8612), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 795, DateTimeKind.Utc).AddTicks(7979), 3L, "Mississippi", 8, 3L },
                    { 99L, new DateTime(2020, 3, 12, 15, 45, 26, 802, DateTimeKind.Utc).AddTicks(1693), 2L, new DateTime(2020, 11, 24, 7, 14, 8, 367, DateTimeKind.Local).AddTicks(9211), null, null, new DateTime(2020, 3, 12, 15, 45, 26, 802, DateTimeKind.Utc).AddTicks(1701), 4L, "Response", 0, 5L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_address_address_fk_address_company_type",
                table: "address_address",
                column: "fk_address_company_type");

            migrationBuilder.CreateIndex(
                name: "IX_address_address_fk_address_country",
                table: "address_address",
                column: "fk_address_country");

            migrationBuilder.CreateIndex(
                name: "IX_address_address_fk_logo",
                table: "address_address",
                column: "fk_logo");

            migrationBuilder.CreateIndex(
                name: "IX_address_address_fk_parent_address",
                table: "address_address",
                column: "fk_parent_address");

            migrationBuilder.CreateIndex(
                name: "IX_address_person_fk_picture",
                table: "address_person",
                column: "fk_picture");

            migrationBuilder.CreateIndex(
                name: "IX_address_person_relation_fk_person",
                table: "address_person_relation",
                column: "fk_person");

            migrationBuilder.CreateIndex(
                name: "IX_article_article_fk_group",
                table: "article_article",
                column: "fk_group");

            migrationBuilder.CreateIndex(
                name: "IX_article_article_fk_type",
                table: "article_article",
                column: "fk_type");

            migrationBuilder.CreateIndex(
                name: "IX_article_article_fk_picture_1",
                table: "article_article",
                column: "fk_picture_1");

            migrationBuilder.CreateIndex(
                name: "IX_article_article_fk_picture_2",
                table: "article_article",
                column: "fk_picture_2");

            migrationBuilder.CreateIndex(
                name: "IX_article_inventory_fk_article",
                table: "article_inventory",
                column: "fk_article");

            migrationBuilder.CreateIndex(
                name: "IX_article_inventory_ArticlePlaceId",
                table: "article_inventory",
                column: "ArticlePlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_article_places_fk_address",
                table: "article_places",
                column: "fk_address");

            migrationBuilder.CreateIndex(
                name: "IX_article_places_ArticleId",
                table: "article_places",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_article_pricelist_fk_article",
                table: "article_pricelist",
                column: "fk_article");

            migrationBuilder.CreateIndex(
                name: "IX_article_pricelist_fk_article1",
                table: "article_pricelist",
                column: "fk_article");

            migrationBuilder.CreateIndex(
                name: "IX_article_range_fk_pricelist",
                table: "article_range",
                column: "fk_pricelist");

            migrationBuilder.CreateIndex(
                name: "IX_document_document_DeliveryAddressId",
                table: "document_document",
                column: "DeliveryAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_document_document_DeliveryPersonId",
                table: "document_document",
                column: "DeliveryPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_document_document_DocumentAddressId",
                table: "document_document",
                column: "DocumentAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_document_document_DocumentPersonId",
                table: "document_document",
                column: "DocumentPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_document_document_InvoiceAddressId",
                table: "document_document",
                column: "InvoiceAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_document_document_InvoicePersonId",
                table: "document_document",
                column: "InvoicePersonId");

            migrationBuilder.CreateIndex(
                name: "IX_document_position_DocumentId",
                table: "document_position",
                column: "DocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_document_position_ParentId",
                table: "document_position",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_WeatherForecast_UserId",
                table: "WeatherForecast",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "address_person_relation");

            migrationBuilder.DropTable(
                name: "article_article_text");

            migrationBuilder.DropTable(
                name: "article_inventory");

            migrationBuilder.DropTable(
                name: "article_range");

            migrationBuilder.DropTable(
                name: "Audit_WeatherForecast");

            migrationBuilder.DropTable(
                name: "document_position");

            migrationBuilder.DropTable(
                name: "WeatherForecast");

            migrationBuilder.DropTable(
                name: "article_places");

            migrationBuilder.DropTable(
                name: "article_pricelist");

            migrationBuilder.DropTable(
                name: "document_document");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "article_article");

            migrationBuilder.DropTable(
                name: "address_address");

            migrationBuilder.DropTable(
                name: "address_person");

            migrationBuilder.DropTable(
                name: "article_group");

            migrationBuilder.DropTable(
                name: "article_type");

            migrationBuilder.DropTable(
                name: "address_company_type");

            migrationBuilder.DropTable(
                name: "address_country");

            migrationBuilder.DropTable(
                name: "fag_binary");
        }
    }
}
