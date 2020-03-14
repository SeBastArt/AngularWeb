using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AngularWeb.Migrations
{
    public partial class Initial : Migration
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
                    user_id = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherForecast", x => x.WeatherForecastId);
                    table.ForeignKey(
                        name: "FK_WeatherForecast_User_user_id",
                        column: x => x.user_id,
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
                    { 1L, "Yvette", "Marquardt", new byte[] { 248, 104, 76, 92, 241, 136, 97, 189, 164, 165, 51, 37, 101, 128, 68, 233, 201, 184, 228, 218, 140, 212, 103, 116, 197, 113, 91, 120, 20, 59, 215, 204, 221, 135, 147, 9, 121, 111, 240, 49, 192, 178, 217, 130, 124, 37, 11, 96, 34, 15, 148, 52, 8, 186, 186, 187, 43, 52, 157, 215, 117, 243, 55, 196 }, new byte[] { 6, 2, 92, 239, 99, 54, 88, 181, 187, 181, 63, 19, 185, 234, 137, 57, 29, 34, 172, 33, 118, 176, 184, 27, 8, 97, 199, 194, 240, 255, 131, 26, 13, 11, 152, 4, 164, 95, 35, 245, 60, 127, 97, 197, 52, 159, 110, 168, 36, 251, 5, 249, 87, 64, 29, 134, 164, 115, 193, 245, 35, 189, 185, 94, 163, 108, 124, 230, 53, 140, 112, 183, 22, 60, 239, 67, 3, 161, 133, 205, 253, 80, 241, 77, 81, 187, 234, 168, 1, 72, 16, 54, 229, 36, 53, 188, 192, 33, 173, 179, 16, 52, 88, 40, 225, 78, 229, 147, 166, 246, 45, 138, 7, 12, 186, 240, 221, 217, 77, 13, 202, 60, 193, 197, 222, 156, 169, 38 }, "Admin", "Nigel" },
                    { 2L, "Joelle", "Bergstrom", new byte[] { 248, 104, 76, 92, 241, 136, 97, 189, 164, 165, 51, 37, 101, 128, 68, 233, 201, 184, 228, 218, 140, 212, 103, 116, 197, 113, 91, 120, 20, 59, 215, 204, 221, 135, 147, 9, 121, 111, 240, 49, 192, 178, 217, 130, 124, 37, 11, 96, 34, 15, 148, 52, 8, 186, 186, 187, 43, 52, 157, 215, 117, 243, 55, 196 }, new byte[] { 6, 2, 92, 239, 99, 54, 88, 181, 187, 181, 63, 19, 185, 234, 137, 57, 29, 34, 172, 33, 118, 176, 184, 27, 8, 97, 199, 194, 240, 255, 131, 26, 13, 11, 152, 4, 164, 95, 35, 245, 60, 127, 97, 197, 52, 159, 110, 168, 36, 251, 5, 249, 87, 64, 29, 134, 164, 115, 193, 245, 35, 189, 185, 94, 163, 108, 124, 230, 53, 140, 112, 183, 22, 60, 239, 67, 3, 161, 133, 205, 253, 80, 241, 77, 81, 187, 234, 168, 1, 72, 16, 54, 229, 36, 53, 188, 192, 33, 173, 179, 16, 52, 88, 40, 225, 78, 229, 147, 166, 246, 45, 138, 7, 12, 186, 240, 221, 217, 77, 13, 202, 60, 193, 197, 222, 156, 169, 38 }, "Admin", "Travis" },
                    { 3L, "Madisyn", "McCullough", new byte[] { 248, 104, 76, 92, 241, 136, 97, 189, 164, 165, 51, 37, 101, 128, 68, 233, 201, 184, 228, 218, 140, 212, 103, 116, 197, 113, 91, 120, 20, 59, 215, 204, 221, 135, 147, 9, 121, 111, 240, 49, 192, 178, 217, 130, 124, 37, 11, 96, 34, 15, 148, 52, 8, 186, 186, 187, 43, 52, 157, 215, 117, 243, 55, 196 }, new byte[] { 6, 2, 92, 239, 99, 54, 88, 181, 187, 181, 63, 19, 185, 234, 137, 57, 29, 34, 172, 33, 118, 176, 184, 27, 8, 97, 199, 194, 240, 255, 131, 26, 13, 11, 152, 4, 164, 95, 35, 245, 60, 127, 97, 197, 52, 159, 110, 168, 36, 251, 5, 249, 87, 64, 29, 134, 164, 115, 193, 245, 35, 189, 185, 94, 163, 108, 124, 230, 53, 140, 112, 183, 22, 60, 239, 67, 3, 161, 133, 205, 253, 80, 241, 77, 81, 187, 234, 168, 1, 72, 16, 54, 229, 36, 53, 188, 192, 33, 173, 179, 16, 52, 88, 40, 225, 78, 229, 147, 166, 246, 45, 138, 7, 12, 186, 240, 221, 217, 77, 13, 202, 60, 193, 197, 222, 156, 169, 38 }, "Admin", "Coralie" },
                    { 4L, "Donna", "Leannon", new byte[] { 248, 104, 76, 92, 241, 136, 97, 189, 164, 165, 51, 37, 101, 128, 68, 233, 201, 184, 228, 218, 140, 212, 103, 116, 197, 113, 91, 120, 20, 59, 215, 204, 221, 135, 147, 9, 121, 111, 240, 49, 192, 178, 217, 130, 124, 37, 11, 96, 34, 15, 148, 52, 8, 186, 186, 187, 43, 52, 157, 215, 117, 243, 55, 196 }, new byte[] { 6, 2, 92, 239, 99, 54, 88, 181, 187, 181, 63, 19, 185, 234, 137, 57, 29, 34, 172, 33, 118, 176, 184, 27, 8, 97, 199, 194, 240, 255, 131, 26, 13, 11, 152, 4, 164, 95, 35, 245, 60, 127, 97, 197, 52, 159, 110, 168, 36, 251, 5, 249, 87, 64, 29, 134, 164, 115, 193, 245, 35, 189, 185, 94, 163, 108, 124, 230, 53, 140, 112, 183, 22, 60, 239, 67, 3, 161, 133, 205, 253, 80, 241, 77, 81, 187, 234, 168, 1, 72, 16, 54, 229, 36, 53, 188, 192, 33, 173, 179, 16, 52, 88, 40, 225, 78, 229, 147, 166, 246, 45, 138, 7, 12, 186, 240, 221, 217, 77, 13, 202, 60, 193, 197, 222, 156, 169, 38 }, "Admin", "Yesenia" },
                    { 5L, "Sebastian", "Schüler", new byte[] { 248, 104, 76, 92, 241, 136, 97, 189, 164, 165, 51, 37, 101, 128, 68, 233, 201, 184, 228, 218, 140, 212, 103, 116, 197, 113, 91, 120, 20, 59, 215, 204, 221, 135, 147, 9, 121, 111, 240, 49, 192, 178, 217, 130, 124, 37, 11, 96, 34, 15, 148, 52, 8, 186, 186, 187, 43, 52, 157, 215, 117, 243, 55, 196 }, new byte[] { 6, 2, 92, 239, 99, 54, 88, 181, 187, 181, 63, 19, 185, 234, 137, 57, 29, 34, 172, 33, 118, 176, 184, 27, 8, 97, 199, 194, 240, 255, 131, 26, 13, 11, 152, 4, 164, 95, 35, 245, 60, 127, 97, 197, 52, 159, 110, 168, 36, 251, 5, 249, 87, 64, 29, 134, 164, 115, 193, 245, 35, 189, 185, 94, 163, 108, 124, 230, 53, 140, 112, 183, 22, 60, 239, 67, 3, 161, 133, 205, 253, 80, 241, 77, 81, 187, 234, 168, 1, 72, 16, 54, 229, 36, 53, 188, 192, 33, 173, 179, 16, 52, 88, 40, 225, 78, 229, 147, 166, 246, 45, 138, 7, 12, 186, 240, 221, 217, 77, 13, 202, 60, 193, 197, 222, 156, 169, 38 }, "Admin", "user" }
                });

            migrationBuilder.InsertData(
                table: "WeatherForecast",
                columns: new[] { "WeatherForecastId", "created", "created_by", "Date", "info", "info_rtf", "modified", "modified_by", "summar_y", "TemperatureC", "user_id" },
                values: new object[,]
                {
                    { 3L, new DateTime(2020, 3, 13, 22, 39, 27, 795, DateTimeKind.Utc).AddTicks(7883), 1L, new DateTime(2020, 8, 2, 2, 24, 24, 879, DateTimeKind.Local).AddTicks(8269), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 795, DateTimeKind.Utc).AddTicks(7886), 5L, "orchid", 5, 1L },
                    { 69L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(4051), 2L, new DateTime(2021, 1, 10, 0, 5, 34, 154, DateTimeKind.Local).AddTicks(4636), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(4053), 3L, "Corporate", -14, 4L },
                    { 64L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(3899), 2L, new DateTime(2020, 7, 2, 13, 17, 22, 747, DateTimeKind.Local).AddTicks(4755), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(3900), 2L, "input", 1, 4L },
                    { 62L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(3851), 2L, new DateTime(2020, 8, 25, 2, 41, 37, 709, DateTimeKind.Local).AddTicks(4130), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(3853), 2L, "cultivate", -12, 4L },
                    { 59L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(3780), 1L, new DateTime(2020, 10, 5, 1, 26, 10, 566, DateTimeKind.Local).AddTicks(7092), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(3782), 1L, "scale", -15, 4L },
                    { 54L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(3652), 2L, new DateTime(2020, 5, 27, 0, 52, 48, 609, DateTimeKind.Local).AddTicks(2178), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(3653), 5L, "Internal", 11, 4L },
                    { 41L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(1352), 2L, new DateTime(2021, 1, 9, 8, 21, 2, 275, DateTimeKind.Local).AddTicks(759), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(1354), 4L, "Metal", -1, 4L },
                    { 39L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(926), 4L, new DateTime(2021, 2, 23, 21, 21, 42, 544, DateTimeKind.Local).AddTicks(4281), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(928), 4L, "calculating", 9, 4L },
                    { 36L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(839), 1L, new DateTime(2020, 10, 10, 6, 5, 47, 255, DateTimeKind.Local).AddTicks(7511), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(841), 1L, "Mobility", 4, 4L },
                    { 24L, new DateTime(2020, 3, 13, 22, 39, 27, 797, DateTimeKind.Utc).AddTicks(8194), 2L, new DateTime(2020, 9, 30, 6, 7, 42, 965, DateTimeKind.Local).AddTicks(3788), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 797, DateTimeKind.Utc).AddTicks(8196), 3L, "backing up", -13, 4L },
                    { 17L, new DateTime(2020, 3, 13, 22, 39, 27, 797, DateTimeKind.Utc).AddTicks(2926), 4L, new DateTime(2020, 4, 20, 19, 26, 14, 334, DateTimeKind.Local).AddTicks(8950), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 797, DateTimeKind.Utc).AddTicks(2928), 5L, "open-source", -9, 4L },
                    { 16L, new DateTime(2020, 3, 13, 22, 39, 27, 797, DateTimeKind.Utc).AddTicks(2884), 3L, new DateTime(2020, 12, 9, 5, 27, 25, 946, DateTimeKind.Local).AddTicks(9771), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 797, DateTimeKind.Utc).AddTicks(2887), 4L, "Planner", 14, 4L },
                    { 15L, new DateTime(2020, 3, 13, 22, 39, 27, 797, DateTimeKind.Utc).AddTicks(2010), 1L, new DateTime(2020, 4, 10, 10, 42, 17, 768, DateTimeKind.Local).AddTicks(4287), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 797, DateTimeKind.Utc).AddTicks(2012), 1L, "national", -9, 4L },
                    { 1L, new DateTime(2020, 3, 13, 22, 39, 27, 795, DateTimeKind.Utc).AddTicks(426), 4L, new DateTime(2020, 12, 24, 15, 50, 41, 290, DateTimeKind.Local).AddTicks(7447), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 795, DateTimeKind.Utc).AddTicks(1701), 4L, "Danish Krone", 15, 4L },
                    { 97L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(7727), 5L, new DateTime(2021, 2, 12, 4, 0, 5, 665, DateTimeKind.Local).AddTicks(4764), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(7729), 4L, "Cayman Islands", 13, 3L },
                    { 95L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(6811), 5L, new DateTime(2021, 1, 27, 13, 6, 9, 777, DateTimeKind.Local).AddTicks(453), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(6813), 4L, "web-enabled", -12, 3L },
                    { 94L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(6787), 1L, new DateTime(2021, 2, 18, 20, 54, 15, 820, DateTimeKind.Local).AddTicks(2902), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(6789), 4L, "Centralized", 11, 3L },
                    { 89L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(6651), 1L, new DateTime(2020, 11, 17, 2, 27, 19, 194, DateTimeKind.Local).AddTicks(8159), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(6653), 5L, "District", -13, 3L },
                    { 87L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(6593), 4L, new DateTime(2020, 10, 9, 0, 26, 40, 365, DateTimeKind.Local).AddTicks(5531), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(6595), 5L, "world-class", 15, 3L },
                    { 83L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(4794), 1L, new DateTime(2020, 11, 29, 17, 16, 29, 803, DateTimeKind.Local).AddTicks(3272), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(4795), 1L, "open-source", 12, 3L },
                    { 78L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(4669), 5L, new DateTime(2020, 12, 31, 16, 3, 20, 929, DateTimeKind.Local).AddTicks(1499), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(4670), 1L, "wireless", -14, 3L },
                    { 77L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(4632), 1L, new DateTime(2021, 1, 12, 22, 37, 28, 996, DateTimeKind.Local).AddTicks(600), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(4634), 2L, "Square", 7, 3L },
                    { 71L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(4110), 2L, new DateTime(2021, 2, 18, 20, 16, 55, 520, DateTimeKind.Local).AddTicks(7667), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(4112), 4L, "connecting", 4, 4L },
                    { 73L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(4158), 1L, new DateTime(2020, 12, 3, 13, 12, 11, 973, DateTimeKind.Local).AddTicks(7695), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(4159), 5L, "scale", 6, 3L },
                    { 72L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(4134), 5L, new DateTime(2020, 10, 4, 5, 51, 32, 246, DateTimeKind.Local).AddTicks(5155), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(4136), 5L, "Gorgeous", -2, 4L },
                    { 76L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(4230), 1L, new DateTime(2020, 7, 18, 9, 16, 35, 544, DateTimeKind.Local).AddTicks(9550), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(4231), 4L, "Officer", 7, 4L },
                    { 96L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(6835), 1L, new DateTime(2020, 4, 27, 22, 46, 27, 200, DateTimeKind.Local).AddTicks(3628), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(6837), 4L, "Credit Card Account", -12, 5L },
                    { 81L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(4745), 1L, new DateTime(2021, 1, 9, 8, 14, 3, 383, DateTimeKind.Local).AddTicks(996), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(4747), 5L, "Maine", -3, 5L },
                    { 66L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(3971), 1L, new DateTime(2020, 8, 30, 4, 58, 37, 526, DateTimeKind.Local).AddTicks(4413), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(3973), 5L, "Lead", 4, 5L },
                    { 65L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(3946), 5L, new DateTime(2020, 6, 13, 14, 54, 15, 739, DateTimeKind.Local).AddTicks(67), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(3948), 4L, "Movies & Clothing", -3, 5L },
                    { 63L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(3875), 1L, new DateTime(2020, 7, 23, 14, 12, 42, 141, DateTimeKind.Local).AddTicks(7815), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(3876), 4L, "Advanced", 14, 5L },
                    { 55L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(3681), 2L, new DateTime(2020, 3, 20, 18, 2, 44, 590, DateTimeKind.Local).AddTicks(5404), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(3683), 4L, "Guarani", -6, 5L },
                    { 52L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(3604), 2L, new DateTime(2020, 9, 7, 21, 38, 43, 116, DateTimeKind.Local).AddTicks(8312), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(3606), 4L, "Brand", 0, 5L },
                    { 44L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(1614), 3L, new DateTime(2020, 5, 8, 13, 7, 17, 358, DateTimeKind.Local).AddTicks(540), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(1616), 5L, "Tunisian Dinar", -3, 5L },
                    { 42L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(1537), 5L, new DateTime(2020, 7, 19, 13, 0, 26, 886, DateTimeKind.Local).AddTicks(7656), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(1538), 5L, "Baby, Beauty & Games", -4, 5L },
                    { 40L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(951), 5L, new DateTime(2020, 8, 13, 23, 12, 14, 629, DateTimeKind.Local).AddTicks(2816), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(953), 2L, "auxiliary", -10, 5L },
                    { 33L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(735), 5L, new DateTime(2020, 3, 26, 11, 39, 36, 645, DateTimeKind.Local).AddTicks(6365), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(738), 5L, "Principal", 3, 5L },
                    { 28L, new DateTime(2020, 3, 13, 22, 39, 27, 797, DateTimeKind.Utc).AddTicks(8334), 3L, new DateTime(2020, 8, 26, 0, 9, 54, 156, DateTimeKind.Local).AddTicks(8672), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 797, DateTimeKind.Utc).AddTicks(8336), 1L, "Self-enabling", 10, 5L },
                    { 26L, new DateTime(2020, 3, 13, 22, 39, 27, 797, DateTimeKind.Utc).AddTicks(8282), 3L, new DateTime(2020, 5, 24, 16, 7, 13, 127, DateTimeKind.Local).AddTicks(4932), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 797, DateTimeKind.Utc).AddTicks(8284), 5L, "Practical Metal Hat", -12, 5L },
                    { 22L, new DateTime(2020, 3, 13, 22, 39, 27, 797, DateTimeKind.Utc).AddTicks(6425), 2L, new DateTime(2021, 1, 4, 3, 39, 6, 796, DateTimeKind.Local).AddTicks(4213), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 797, DateTimeKind.Utc).AddTicks(6427), 4L, "Technician", 3, 5L },
                    { 20L, new DateTime(2020, 3, 13, 22, 39, 27, 797, DateTimeKind.Utc).AddTicks(5319), 2L, new DateTime(2020, 12, 2, 1, 26, 49, 278, DateTimeKind.Local).AddTicks(9484), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 797, DateTimeKind.Utc).AddTicks(5322), 4L, "Kids, Electronics & Movies", 5, 5L },
                    { 11L, new DateTime(2020, 3, 13, 22, 39, 27, 797, DateTimeKind.Utc).AddTicks(661), 1L, new DateTime(2020, 3, 14, 13, 53, 20, 434, DateTimeKind.Local).AddTicks(7089), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 797, DateTimeKind.Utc).AddTicks(663), 1L, "Handmade Plastic Towels", -7, 5L },
                    { 5L, new DateTime(2020, 3, 13, 22, 39, 27, 796, DateTimeKind.Utc).AddTicks(33), 2L, new DateTime(2021, 2, 22, 19, 31, 32, 191, DateTimeKind.Local).AddTicks(6269), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 796, DateTimeKind.Utc).AddTicks(35), 3L, "sexy", -14, 5L },
                    { 93L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(6764), 3L, new DateTime(2020, 8, 2, 18, 41, 14, 841, DateTimeKind.Local).AddTicks(8473), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(6766), 3L, "Latvian Lats", -6, 4L },
                    { 88L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(6618), 5L, new DateTime(2021, 1, 24, 15, 32, 26, 815, DateTimeKind.Local).AddTicks(9649), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(6619), 2L, "Triple-buffered", 10, 4L },
                    { 86L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(6567), 1L, new DateTime(2020, 9, 30, 23, 53, 23, 541, DateTimeKind.Local).AddTicks(1761), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(6569), 5L, "Walks", 8, 4L },
                    { 82L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(4770), 3L, new DateTime(2020, 5, 31, 23, 27, 14, 432, DateTimeKind.Local).AddTicks(9909), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(4771), 2L, "AI", 8, 4L },
                    { 74L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(4181), 5L, new DateTime(2020, 6, 2, 9, 4, 10, 506, DateTimeKind.Local).AddTicks(8263), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(4183), 5L, "olive", 4, 4L },
                    { 68L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(4022), 1L, new DateTime(2020, 10, 1, 23, 49, 52, 562, DateTimeKind.Local).AddTicks(5046), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(4023), 5L, "real-time", 2, 3L },
                    { 61L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(3828), 3L, new DateTime(2020, 7, 24, 1, 34, 19, 439, DateTimeKind.Local).AddTicks(3794), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(3829), 2L, "SMS", -14, 3L },
                    { 58L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(3754), 3L, new DateTime(2021, 3, 13, 21, 41, 29, 10, DateTimeKind.Local).AddTicks(1730), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(3756), 4L, "index", 14, 3L },
                    { 27L, new DateTime(2020, 3, 13, 22, 39, 27, 797, DateTimeKind.Utc).AddTicks(8308), 2L, new DateTime(2020, 7, 10, 1, 43, 10, 991, DateTimeKind.Local).AddTicks(8889), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 797, DateTimeKind.Utc).AddTicks(8310), 3L, "1080p", 10, 2L },
                    { 14L, new DateTime(2020, 3, 13, 22, 39, 27, 797, DateTimeKind.Utc).AddTicks(1982), 3L, new DateTime(2021, 2, 25, 8, 25, 54, 719, DateTimeKind.Local).AddTicks(9890), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 797, DateTimeKind.Utc).AddTicks(1984), 3L, "Customer-focused", -8, 2L },
                    { 12L, new DateTime(2020, 3, 13, 22, 39, 27, 797, DateTimeKind.Utc).AddTicks(1903), 2L, new DateTime(2020, 3, 28, 21, 4, 41, 330, DateTimeKind.Local).AddTicks(9578), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 797, DateTimeKind.Utc).AddTicks(1906), 1L, "Assurance", 10, 2L },
                    { 10L, new DateTime(2020, 3, 13, 22, 39, 27, 796, DateTimeKind.Utc).AddTicks(8576), 4L, new DateTime(2020, 5, 21, 19, 45, 17, 817, DateTimeKind.Local).AddTicks(6151), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 796, DateTimeKind.Utc).AddTicks(8579), 5L, "hard drive", 15, 2L },
                    { 7L, new DateTime(2020, 3, 13, 22, 39, 27, 796, DateTimeKind.Utc).AddTicks(2117), 4L, new DateTime(2020, 4, 15, 11, 42, 48, 903, DateTimeKind.Local).AddTicks(6482), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 796, DateTimeKind.Utc).AddTicks(2120), 3L, "Fully-configurable", -3, 2L },
                    { 4L, new DateTime(2020, 3, 13, 22, 39, 27, 795, DateTimeKind.Utc).AddTicks(8798), 3L, new DateTime(2020, 6, 2, 18, 35, 14, 838, DateTimeKind.Local).AddTicks(4668), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 795, DateTimeKind.Utc).AddTicks(8800), 1L, "Practical", -3, 2L },
                    { 100L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(8655), 1L, new DateTime(2020, 10, 8, 20, 46, 29, 610, DateTimeKind.Local).AddTicks(8146), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(8657), 5L, "Tasty Rubber Keyboard", 0, 1L },
                    { 92L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(6735), 1L, new DateTime(2021, 1, 27, 10, 1, 23, 779, DateTimeKind.Local).AddTicks(263), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(6736), 2L, "parse", 10, 1L },
                    { 91L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(6710), 1L, new DateTime(2020, 6, 7, 6, 41, 21, 575, DateTimeKind.Local).AddTicks(2796), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(6712), 5L, "driver", -10, 1L },
                    { 90L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(6686), 2L, new DateTime(2020, 11, 30, 18, 40, 3, 76, DateTimeKind.Local).AddTicks(7892), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(6688), 2L, "Small Cotton Keyboard", 2, 1L },
                    { 84L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(5626), 4L, new DateTime(2020, 7, 31, 21, 10, 27, 428, DateTimeKind.Local).AddTicks(6228), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(5629), 5L, "Berkshire", -11, 1L },
                    { 75L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(4205), 3L, new DateTime(2020, 4, 8, 6, 40, 4, 734, DateTimeKind.Local).AddTicks(7700), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(4207), 1L, "Pre-emptive", -3, 1L },
                    { 60L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(3804), 5L, new DateTime(2021, 2, 18, 21, 23, 42, 260, DateTimeKind.Local).AddTicks(6226), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(3806), 2L, "supply-chains", -8, 1L },
                    { 57L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(3730), 3L, new DateTime(2020, 6, 21, 9, 17, 44, 17, DateTimeKind.Local).AddTicks(2353), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(3732), 3L, "online", 4, 1L },
                    { 56L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(3706), 5L, new DateTime(2020, 7, 2, 16, 42, 23, 995, DateTimeKind.Local).AddTicks(7664), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(3707), 3L, "Central", 8, 1L },
                    { 51L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(3580), 1L, new DateTime(2021, 2, 23, 5, 33, 38, 744, DateTimeKind.Local).AddTicks(9799), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(3581), 5L, "Implementation", 0, 1L },
                    { 49L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(3456), 3L, new DateTime(2021, 3, 1, 14, 41, 29, 37, DateTimeKind.Local).AddTicks(1401), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(3459), 2L, "Trafficway", 15, 1L },
                    { 37L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(865), 2L, new DateTime(2020, 10, 13, 17, 6, 2, 992, DateTimeKind.Local).AddTicks(1718), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(867), 3L, "cyan", -4, 1L },
                    { 30L, new DateTime(2020, 3, 13, 22, 39, 27, 797, DateTimeKind.Utc).AddTicks(9310), 5L, new DateTime(2020, 4, 14, 21, 27, 41, 711, DateTimeKind.Local).AddTicks(4996), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 797, DateTimeKind.Utc).AddTicks(9312), 1L, "connecting", -8, 1L },
                    { 29L, new DateTime(2020, 3, 13, 22, 39, 27, 797, DateTimeKind.Utc).AddTicks(9270), 3L, new DateTime(2020, 7, 17, 3, 36, 1, 952, DateTimeKind.Local).AddTicks(8873), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 797, DateTimeKind.Utc).AddTicks(9273), 3L, "Credit Card Account", 0, 1L },
                    { 25L, new DateTime(2020, 3, 13, 22, 39, 27, 797, DateTimeKind.Utc).AddTicks(8240), 4L, new DateTime(2020, 10, 12, 5, 22, 45, 767, DateTimeKind.Local).AddTicks(4200), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 797, DateTimeKind.Utc).AddTicks(8242), 3L, "Delaware", -1, 1L },
                    { 31L, new DateTime(2020, 3, 13, 22, 39, 27, 797, DateTimeKind.Utc).AddTicks(9347), 4L, new DateTime(2021, 2, 4, 6, 30, 29, 63, DateTimeKind.Local).AddTicks(7390), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 797, DateTimeKind.Utc).AddTicks(9349), 1L, "Incredible Wooden Shoes", -8, 2L },
                    { 32L, new DateTime(2020, 3, 13, 22, 39, 27, 797, DateTimeKind.Utc).AddTicks(9752), 2L, new DateTime(2020, 7, 19, 3, 8, 2, 320, DateTimeKind.Local).AddTicks(5647), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 797, DateTimeKind.Utc).AddTicks(9755), 4L, "Rustic Steel Pants", 13, 2L },
                    { 34L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(787), 2L, new DateTime(2021, 2, 27, 13, 13, 59, 962, DateTimeKind.Local).AddTicks(7077), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(788), 2L, "e-markets", -11, 2L },
                    { 38L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(901), 3L, new DateTime(2020, 7, 14, 10, 20, 58, 449, DateTimeKind.Local).AddTicks(3602), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(903), 4L, "Intelligent Concrete Shoes", 14, 2L },
                    { 53L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(3627), 3L, new DateTime(2020, 3, 21, 10, 7, 25, 743, DateTimeKind.Local).AddTicks(1173), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(3629), 5L, "Identity", -14, 3L },
                    { 50L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(3552), 5L, new DateTime(2020, 8, 20, 19, 13, 59, 984, DateTimeKind.Local).AddTicks(1166), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(3554), 2L, "Direct", 3, 3L },
                    { 48L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(2600), 1L, new DateTime(2020, 8, 23, 19, 57, 42, 146, DateTimeKind.Local).AddTicks(7867), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(2602), 5L, "Brazilian Real", -6, 3L },
                    { 47L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(2570), 4L, new DateTime(2020, 4, 17, 8, 7, 5, 57, DateTimeKind.Local).AddTicks(77), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(2572), 4L, "fuchsia", -3, 3L },
                    { 45L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(2506), 3L, new DateTime(2021, 1, 8, 9, 2, 39, 399, DateTimeKind.Local).AddTicks(7287), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(2509), 2L, "bypass", 14, 3L },
                    { 35L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(813), 2L, new DateTime(2020, 5, 16, 0, 32, 46, 740, DateTimeKind.Local).AddTicks(4574), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(815), 2L, "efficient", -1, 3L },
                    { 23L, new DateTime(2020, 3, 13, 22, 39, 27, 797, DateTimeKind.Utc).AddTicks(7324), 3L, new DateTime(2021, 2, 7, 10, 11, 39, 623, DateTimeKind.Local).AddTicks(1848), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 797, DateTimeKind.Utc).AddTicks(7326), 1L, "COM", -8, 3L },
                    { 21L, new DateTime(2020, 3, 13, 22, 39, 27, 797, DateTimeKind.Utc).AddTicks(6377), 5L, new DateTime(2020, 3, 28, 4, 2, 29, 534, DateTimeKind.Local).AddTicks(899), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 797, DateTimeKind.Utc).AddTicks(6380), 5L, "reinvent", 12, 3L },
                    { 19L, new DateTime(2020, 3, 13, 22, 39, 27, 797, DateTimeKind.Utc).AddTicks(3886), 3L, new DateTime(2020, 10, 14, 14, 14, 24, 557, DateTimeKind.Local).AddTicks(4067), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 797, DateTimeKind.Utc).AddTicks(3888), 4L, "paradigms", -14, 3L },
                    { 18L, new DateTime(2020, 3, 13, 22, 39, 27, 797, DateTimeKind.Utc).AddTicks(3835), 2L, new DateTime(2020, 8, 19, 2, 23, 37, 400, DateTimeKind.Local).AddTicks(1271), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 797, DateTimeKind.Utc).AddTicks(3847), 3L, "niches", -4, 3L },
                    { 98L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(8577), 4L, new DateTime(2020, 8, 15, 1, 51, 52, 133, DateTimeKind.Local).AddTicks(4395), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(8580), 2L, "withdrawal", 8, 5L },
                    { 13L, new DateTime(2020, 3, 13, 22, 39, 27, 797, DateTimeKind.Utc).AddTicks(1953), 4L, new DateTime(2020, 7, 17, 21, 10, 53, 695, DateTimeKind.Local).AddTicks(5911), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 797, DateTimeKind.Utc).AddTicks(1954), 5L, "mobile", 6, 3L },
                    { 8L, new DateTime(2020, 3, 13, 22, 39, 27, 796, DateTimeKind.Utc).AddTicks(6085), 3L, new DateTime(2020, 6, 10, 22, 1, 44, 862, DateTimeKind.Local).AddTicks(8838), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 796, DateTimeKind.Utc).AddTicks(6089), 3L, "Jewelery", -15, 3L },
                    { 6L, new DateTime(2020, 3, 13, 22, 39, 27, 796, DateTimeKind.Utc).AddTicks(1126), 4L, new DateTime(2020, 7, 7, 0, 42, 2, 940, DateTimeKind.Local).AddTicks(2981), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 796, DateTimeKind.Utc).AddTicks(1129), 3L, "even-keeled", 14, 3L },
                    { 2L, new DateTime(2020, 3, 13, 22, 39, 27, 795, DateTimeKind.Utc).AddTicks(6431), 3L, new DateTime(2020, 11, 16, 22, 12, 22, 125, DateTimeKind.Local).AddTicks(4857), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 795, DateTimeKind.Utc).AddTicks(6461), 5L, "haptic", -6, 3L },
                    { 85L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(6525), 2L, new DateTime(2020, 5, 11, 23, 39, 36, 512, DateTimeKind.Local).AddTicks(4235), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(6528), 4L, "conglomeration", 10, 2L },
                    { 80L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(4720), 4L, new DateTime(2020, 10, 25, 17, 48, 51, 17, DateTimeKind.Local).AddTicks(6959), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(4721), 5L, "Investment Account", 12, 2L },
                    { 79L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(4693), 5L, new DateTime(2021, 1, 28, 5, 57, 15, 972, DateTimeKind.Local).AddTicks(2469), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(4694), 1L, "SMS", 4, 2L },
                    { 70L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(4086), 3L, new DateTime(2020, 9, 26, 11, 44, 26, 136, DateTimeKind.Local).AddTicks(7417), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(4088), 5L, "Small Cotton Car", -4, 2L },
                    { 67L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(3997), 1L, new DateTime(2021, 1, 18, 11, 16, 9, 554, DateTimeKind.Local).AddTicks(7857), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(3998), 3L, "Agent", -12, 2L },
                    { 46L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(2545), 1L, new DateTime(2021, 1, 2, 14, 12, 13, 974, DateTimeKind.Local).AddTicks(1890), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(2547), 3L, "networks", 13, 2L },
                    { 43L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(1578), 2L, new DateTime(2020, 3, 21, 15, 28, 31, 353, DateTimeKind.Local).AddTicks(1691), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(1580), 4L, "Incredible Frozen Cheese", 15, 2L },
                    { 9L, new DateTime(2020, 3, 13, 22, 39, 27, 796, DateTimeKind.Utc).AddTicks(7492), 2L, new DateTime(2020, 5, 13, 23, 59, 45, 920, DateTimeKind.Local).AddTicks(8180), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 796, DateTimeKind.Utc).AddTicks(7495), 3L, "Mississippi", 8, 3L },
                    { 99L, new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(8619), 2L, new DateTime(2020, 11, 25, 14, 8, 9, 364, DateTimeKind.Local).AddTicks(6163), "", "", new DateTime(2020, 3, 13, 22, 39, 27, 798, DateTimeKind.Utc).AddTicks(8621), 4L, "Response", 0, 5L }
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
                name: "IX_WeatherForecast_user_id",
                table: "WeatherForecast",
                column: "user_id");
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
