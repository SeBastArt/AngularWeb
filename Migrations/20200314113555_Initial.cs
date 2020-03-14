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
                    { 1L, "Yvette", "Marquardt", new byte[] { 46, 207, 197, 56, 247, 52, 182, 130, 230, 179, 167, 141, 154, 48, 53, 130, 98, 167, 157, 214, 51, 109, 233, 163, 211, 240, 144, 75, 95, 159, 75, 89, 227, 123, 146, 111, 131, 50, 15, 186, 134, 10, 255, 249, 27, 10, 99, 85, 88, 225, 213, 214, 236, 192, 103, 7, 213, 95, 129, 45, 59, 106, 12, 226 }, new byte[] { 148, 34, 76, 55, 219, 156, 27, 60, 81, 0, 22, 244, 78, 89, 34, 59, 103, 213, 136, 79, 118, 255, 130, 203, 148, 79, 253, 163, 32, 30, 39, 110, 149, 107, 103, 56, 176, 90, 214, 12, 157, 95, 84, 72, 74, 212, 35, 68, 140, 136, 139, 66, 220, 101, 118, 147, 107, 97, 110, 80, 71, 225, 31, 112, 92, 2, 164, 204, 83, 77, 181, 228, 114, 88, 193, 202, 159, 250, 133, 224, 87, 166, 170, 171, 8, 254, 50, 194, 180, 237, 67, 148, 37, 34, 10, 212, 12, 243, 234, 176, 63, 166, 60, 45, 109, 75, 199, 203, 236, 46, 11, 78, 65, 94, 164, 41, 158, 229, 99, 216, 195, 101, 21, 203, 66, 161, 37, 223 }, "Admin", "Nigel" },
                    { 2L, "Joelle", "Bergstrom", new byte[] { 46, 207, 197, 56, 247, 52, 182, 130, 230, 179, 167, 141, 154, 48, 53, 130, 98, 167, 157, 214, 51, 109, 233, 163, 211, 240, 144, 75, 95, 159, 75, 89, 227, 123, 146, 111, 131, 50, 15, 186, 134, 10, 255, 249, 27, 10, 99, 85, 88, 225, 213, 214, 236, 192, 103, 7, 213, 95, 129, 45, 59, 106, 12, 226 }, new byte[] { 148, 34, 76, 55, 219, 156, 27, 60, 81, 0, 22, 244, 78, 89, 34, 59, 103, 213, 136, 79, 118, 255, 130, 203, 148, 79, 253, 163, 32, 30, 39, 110, 149, 107, 103, 56, 176, 90, 214, 12, 157, 95, 84, 72, 74, 212, 35, 68, 140, 136, 139, 66, 220, 101, 118, 147, 107, 97, 110, 80, 71, 225, 31, 112, 92, 2, 164, 204, 83, 77, 181, 228, 114, 88, 193, 202, 159, 250, 133, 224, 87, 166, 170, 171, 8, 254, 50, 194, 180, 237, 67, 148, 37, 34, 10, 212, 12, 243, 234, 176, 63, 166, 60, 45, 109, 75, 199, 203, 236, 46, 11, 78, 65, 94, 164, 41, 158, 229, 99, 216, 195, 101, 21, 203, 66, 161, 37, 223 }, "Admin", "Travis" },
                    { 3L, "Madisyn", "McCullough", new byte[] { 46, 207, 197, 56, 247, 52, 182, 130, 230, 179, 167, 141, 154, 48, 53, 130, 98, 167, 157, 214, 51, 109, 233, 163, 211, 240, 144, 75, 95, 159, 75, 89, 227, 123, 146, 111, 131, 50, 15, 186, 134, 10, 255, 249, 27, 10, 99, 85, 88, 225, 213, 214, 236, 192, 103, 7, 213, 95, 129, 45, 59, 106, 12, 226 }, new byte[] { 148, 34, 76, 55, 219, 156, 27, 60, 81, 0, 22, 244, 78, 89, 34, 59, 103, 213, 136, 79, 118, 255, 130, 203, 148, 79, 253, 163, 32, 30, 39, 110, 149, 107, 103, 56, 176, 90, 214, 12, 157, 95, 84, 72, 74, 212, 35, 68, 140, 136, 139, 66, 220, 101, 118, 147, 107, 97, 110, 80, 71, 225, 31, 112, 92, 2, 164, 204, 83, 77, 181, 228, 114, 88, 193, 202, 159, 250, 133, 224, 87, 166, 170, 171, 8, 254, 50, 194, 180, 237, 67, 148, 37, 34, 10, 212, 12, 243, 234, 176, 63, 166, 60, 45, 109, 75, 199, 203, 236, 46, 11, 78, 65, 94, 164, 41, 158, 229, 99, 216, 195, 101, 21, 203, 66, 161, 37, 223 }, "Admin", "Coralie" },
                    { 4L, "Donna", "Leannon", new byte[] { 46, 207, 197, 56, 247, 52, 182, 130, 230, 179, 167, 141, 154, 48, 53, 130, 98, 167, 157, 214, 51, 109, 233, 163, 211, 240, 144, 75, 95, 159, 75, 89, 227, 123, 146, 111, 131, 50, 15, 186, 134, 10, 255, 249, 27, 10, 99, 85, 88, 225, 213, 214, 236, 192, 103, 7, 213, 95, 129, 45, 59, 106, 12, 226 }, new byte[] { 148, 34, 76, 55, 219, 156, 27, 60, 81, 0, 22, 244, 78, 89, 34, 59, 103, 213, 136, 79, 118, 255, 130, 203, 148, 79, 253, 163, 32, 30, 39, 110, 149, 107, 103, 56, 176, 90, 214, 12, 157, 95, 84, 72, 74, 212, 35, 68, 140, 136, 139, 66, 220, 101, 118, 147, 107, 97, 110, 80, 71, 225, 31, 112, 92, 2, 164, 204, 83, 77, 181, 228, 114, 88, 193, 202, 159, 250, 133, 224, 87, 166, 170, 171, 8, 254, 50, 194, 180, 237, 67, 148, 37, 34, 10, 212, 12, 243, 234, 176, 63, 166, 60, 45, 109, 75, 199, 203, 236, 46, 11, 78, 65, 94, 164, 41, 158, 229, 99, 216, 195, 101, 21, 203, 66, 161, 37, 223 }, "Admin", "Yesenia" },
                    { 5L, "Sebastian", "Schüler", new byte[] { 46, 207, 197, 56, 247, 52, 182, 130, 230, 179, 167, 141, 154, 48, 53, 130, 98, 167, 157, 214, 51, 109, 233, 163, 211, 240, 144, 75, 95, 159, 75, 89, 227, 123, 146, 111, 131, 50, 15, 186, 134, 10, 255, 249, 27, 10, 99, 85, 88, 225, 213, 214, 236, 192, 103, 7, 213, 95, 129, 45, 59, 106, 12, 226 }, new byte[] { 148, 34, 76, 55, 219, 156, 27, 60, 81, 0, 22, 244, 78, 89, 34, 59, 103, 213, 136, 79, 118, 255, 130, 203, 148, 79, 253, 163, 32, 30, 39, 110, 149, 107, 103, 56, 176, 90, 214, 12, 157, 95, 84, 72, 74, 212, 35, 68, 140, 136, 139, 66, 220, 101, 118, 147, 107, 97, 110, 80, 71, 225, 31, 112, 92, 2, 164, 204, 83, 77, 181, 228, 114, 88, 193, 202, 159, 250, 133, 224, 87, 166, 170, 171, 8, 254, 50, 194, 180, 237, 67, 148, 37, 34, 10, 212, 12, 243, 234, 176, 63, 166, 60, 45, 109, 75, 199, 203, 236, 46, 11, 78, 65, 94, 164, 41, 158, 229, 99, 216, 195, 101, 21, 203, 66, 161, 37, 223 }, "Admin", "user" }
                });

            migrationBuilder.InsertData(
                table: "WeatherForecast",
                columns: new[] { "WeatherForecastId", "created", "created_by", "Date", "info", "info_rtf", "modified", "modified_by", "summar_y", "TemperatureC", "user_id" },
                values: new object[,]
                {
                    { 3L, new DateTime(2020, 3, 14, 11, 35, 54, 386, DateTimeKind.Utc).AddTicks(8816), 1L, new DateTime(2020, 8, 2, 15, 20, 51, 470, DateTimeKind.Local).AddTicks(9162), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 386, DateTimeKind.Utc).AddTicks(8823), 5L, "orchid", 5, 1L },
                    { 69L, new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(8796), 2L, new DateTime(2021, 1, 10, 13, 2, 0, 748, DateTimeKind.Local).AddTicks(9374), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(8800), 3L, "Corporate", -14, 4L },
                    { 64L, new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(8462), 2L, new DateTime(2020, 7, 3, 2, 13, 49, 341, DateTimeKind.Local).AddTicks(9311), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(8466), 2L, "input", 1, 4L },
                    { 62L, new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(8355), 2L, new DateTime(2020, 8, 25, 15, 38, 4, 303, DateTimeKind.Local).AddTicks(8627), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(8359), 2L, "cultivate", -12, 4L },
                    { 59L, new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(8191), 1L, new DateTime(2020, 10, 5, 14, 22, 37, 161, DateTimeKind.Local).AddTicks(1495), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(8195), 1L, "scale", -15, 4L },
                    { 54L, new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(7881), 2L, new DateTime(2020, 5, 27, 13, 49, 15, 203, DateTimeKind.Local).AddTicks(6400), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(7885), 5L, "Internal", 11, 4L },
                    { 41L, new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(2677), 2L, new DateTime(2021, 1, 9, 21, 17, 28, 869, DateTimeKind.Local).AddTicks(2058), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(2682), 4L, "Metal", -1, 4L },
                    { 39L, new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(1702), 4L, new DateTime(2021, 2, 24, 10, 18, 9, 138, DateTimeKind.Local).AddTicks(5048), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(1706), 4L, "calculating", 9, 4L },
                    { 36L, new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(1483), 1L, new DateTime(2020, 10, 10, 19, 2, 13, 849, DateTimeKind.Local).AddTicks(8147), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(1486), 1L, "Mobility", 4, 4L },
                    { 24L, new DateTime(2020, 3, 14, 11, 35, 54, 391, DateTimeKind.Utc).AddTicks(5553), 2L, new DateTime(2020, 9, 30, 19, 4, 9, 559, DateTimeKind.Local).AddTicks(1114), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 391, DateTimeKind.Utc).AddTicks(5559), 3L, "backing up", -13, 4L },
                    { 17L, new DateTime(2020, 3, 14, 11, 35, 54, 390, DateTimeKind.Utc).AddTicks(3407), 4L, new DateTime(2020, 4, 21, 8, 22, 40, 927, DateTimeKind.Local).AddTicks(9424), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 390, DateTimeKind.Utc).AddTicks(3411), 5L, "open-source", -9, 4L },
                    { 16L, new DateTime(2020, 3, 14, 11, 35, 54, 390, DateTimeKind.Utc).AddTicks(3310), 3L, new DateTime(2020, 12, 9, 18, 23, 52, 540, DateTimeKind.Local).AddTicks(168), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 390, DateTimeKind.Utc).AddTicks(3316), 4L, "Planner", 14, 4L },
                    { 15L, new DateTime(2020, 3, 14, 11, 35, 54, 390, DateTimeKind.Utc).AddTicks(1304), 1L, new DateTime(2020, 4, 10, 23, 38, 44, 361, DateTimeKind.Local).AddTicks(3573), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 390, DateTimeKind.Utc).AddTicks(1308), 1L, "national", -9, 4L },
                    { 1L, new DateTime(2020, 3, 14, 11, 35, 54, 385, DateTimeKind.Utc).AddTicks(1517), 4L, new DateTime(2020, 12, 25, 4, 47, 7, 878, DateTimeKind.Local).AddTicks(1794), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 385, DateTimeKind.Utc).AddTicks(4427), 4L, "Danish Krone", 15, 4L },
                    { 97L, new DateTime(2020, 3, 14, 11, 35, 54, 393, DateTimeKind.Utc).AddTicks(7533), 5L, new DateTime(2021, 2, 12, 16, 56, 32, 260, DateTimeKind.Local).AddTicks(4541), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 393, DateTimeKind.Utc).AddTicks(7538), 4L, "Cayman Islands", 13, 3L },
                    { 95L, new DateTime(2020, 3, 14, 11, 35, 54, 393, DateTimeKind.Utc).AddTicks(5330), 5L, new DateTime(2021, 1, 28, 2, 2, 36, 371, DateTimeKind.Local).AddTicks(8965), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 393, DateTimeKind.Utc).AddTicks(5334), 4L, "web-enabled", -12, 3L },
                    { 94L, new DateTime(2020, 3, 14, 11, 35, 54, 393, DateTimeKind.Utc).AddTicks(5273), 1L, new DateTime(2021, 2, 19, 9, 50, 42, 415, DateTimeKind.Local).AddTicks(1378), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 393, DateTimeKind.Utc).AddTicks(5277), 4L, "Centralized", 11, 3L },
                    { 89L, new DateTime(2020, 3, 14, 11, 35, 54, 393, DateTimeKind.Utc).AddTicks(4935), 1L, new DateTime(2020, 11, 17, 15, 23, 45, 789, DateTimeKind.Local).AddTicks(6434), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 393, DateTimeKind.Utc).AddTicks(4938), 5L, "District", -13, 3L },
                    { 87L, new DateTime(2020, 3, 14, 11, 35, 54, 393, DateTimeKind.Utc).AddTicks(4820), 4L, new DateTime(2020, 10, 9, 13, 23, 6, 960, DateTimeKind.Local).AddTicks(3750), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 393, DateTimeKind.Utc).AddTicks(4824), 5L, "world-class", 15, 3L },
                    { 83L, new DateTime(2020, 3, 14, 11, 35, 54, 393, DateTimeKind.Utc).AddTicks(579), 1L, new DateTime(2020, 11, 30, 6, 12, 56, 397, DateTimeKind.Local).AddTicks(9050), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 393, DateTimeKind.Utc).AddTicks(583), 1L, "open-source", 12, 3L },
                    { 78L, new DateTime(2020, 3, 14, 11, 35, 54, 393, DateTimeKind.Utc).AddTicks(290), 5L, new DateTime(2021, 1, 1, 4, 59, 47, 523, DateTimeKind.Local).AddTicks(7111), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 393, DateTimeKind.Utc).AddTicks(294), 1L, "wireless", -14, 3L },
                    { 77L, new DateTime(2020, 3, 14, 11, 35, 54, 393, DateTimeKind.Utc).AddTicks(164), 1L, new DateTime(2021, 1, 13, 11, 33, 55, 590, DateTimeKind.Local).AddTicks(6106), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 393, DateTimeKind.Utc).AddTicks(169), 2L, "Square", 7, 3L },
                    { 71L, new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(8934), 2L, new DateTime(2021, 2, 19, 9, 13, 22, 115, DateTimeKind.Local).AddTicks(2483), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(8938), 4L, "connecting", 4, 4L },
                    { 73L, new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(9055), 1L, new DateTime(2020, 12, 4, 2, 8, 38, 568, DateTimeKind.Local).AddTicks(2584), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(9059), 5L, "scale", 6, 3L },
                    { 72L, new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(8991), 5L, new DateTime(2020, 10, 4, 18, 47, 58, 841, DateTimeKind.Local).AddTicks(5), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(8995), 5L, "Gorgeous", -2, 4L },
                    { 76L, new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(9223), 1L, new DateTime(2020, 7, 18, 22, 13, 2, 139, DateTimeKind.Local).AddTicks(4536), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(9226), 4L, "Officer", 7, 4L },
                    { 96L, new DateTime(2020, 3, 14, 11, 35, 54, 393, DateTimeKind.Utc).AddTicks(5387), 1L, new DateTime(2020, 4, 28, 11, 42, 53, 795, DateTimeKind.Local).AddTicks(2172), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 393, DateTimeKind.Utc).AddTicks(5391), 4L, "Credit Card Account", -12, 5L },
                    { 81L, new DateTime(2020, 3, 14, 11, 35, 54, 393, DateTimeKind.Utc).AddTicks(469), 1L, new DateTime(2021, 1, 9, 21, 10, 29, 977, DateTimeKind.Local).AddTicks(6712), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 393, DateTimeKind.Utc).AddTicks(473), 5L, "Maine", -3, 5L },
                    { 66L, new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(8626), 1L, new DateTime(2020, 8, 30, 17, 55, 4, 120, DateTimeKind.Local).AddTicks(9061), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(8630), 5L, "Lead", 4, 5L },
                    { 65L, new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(8568), 5L, new DateTime(2020, 6, 14, 3, 50, 42, 333, DateTimeKind.Local).AddTicks(4679), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(8572), 4L, "Movies & Clothing", -3, 5L },
                    { 63L, new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(8409), 1L, new DateTime(2020, 7, 24, 3, 9, 8, 736, DateTimeKind.Local).AddTicks(2342), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(8413), 4L, "Advanced", 14, 5L },
                    { 55L, new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(7967), 2L, new DateTime(2020, 3, 21, 6, 59, 11, 184, DateTimeKind.Local).AddTicks(9681), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(7970), 4L, "Guarani", -6, 5L },
                    { 52L, new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(7772), 2L, new DateTime(2020, 9, 8, 10, 35, 9, 711, DateTimeKind.Local).AddTicks(2472), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(7776), 4L, "Brand", 0, 5L },
                    { 44L, new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(3262), 3L, new DateTime(2020, 5, 9, 2, 3, 43, 952, DateTimeKind.Local).AddTicks(2179), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(3267), 5L, "Tunisian Dinar", -3, 5L },
                    { 42L, new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(3078), 5L, new DateTime(2020, 7, 20, 1, 56, 53, 480, DateTimeKind.Local).AddTicks(9184), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(3083), 5L, "Baby, Beauty & Games", -4, 5L },
                    { 40L, new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(1760), 5L, new DateTime(2020, 8, 14, 12, 8, 41, 223, DateTimeKind.Local).AddTicks(3616), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(1764), 2L, "auxiliary", -10, 5L },
                    { 33L, new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(1265), 5L, new DateTime(2020, 3, 27, 0, 36, 3, 239, DateTimeKind.Local).AddTicks(6899), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(1270), 5L, "Principal", 3, 5L },
                    { 28L, new DateTime(2020, 3, 14, 11, 35, 54, 391, DateTimeKind.Utc).AddTicks(5880), 3L, new DateTime(2020, 8, 26, 13, 6, 20, 750, DateTimeKind.Local).AddTicks(6211), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 391, DateTimeKind.Utc).AddTicks(5884), 1L, "Self-enabling", 10, 5L },
                    { 26L, new DateTime(2020, 3, 14, 11, 35, 54, 391, DateTimeKind.Utc).AddTicks(5758), 3L, new DateTime(2020, 5, 25, 5, 3, 39, 721, DateTimeKind.Local).AddTicks(2397), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 391, DateTimeKind.Utc).AddTicks(5762), 5L, "Practical Metal Hat", -12, 5L },
                    { 22L, new DateTime(2020, 3, 14, 11, 35, 54, 391, DateTimeKind.Utc).AddTicks(1377), 2L, new DateTime(2021, 1, 4, 16, 35, 33, 389, DateTimeKind.Local).AddTicks(9154), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 391, DateTimeKind.Utc).AddTicks(1382), 4L, "Technician", 3, 5L },
                    { 20L, new DateTime(2020, 3, 14, 11, 35, 54, 390, DateTimeKind.Utc).AddTicks(8737), 2L, new DateTime(2020, 12, 2, 14, 23, 15, 872, DateTimeKind.Local).AddTicks(2865), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 390, DateTimeKind.Utc).AddTicks(8744), 4L, "Kids, Electronics & Movies", 5, 5L },
                    { 11L, new DateTime(2020, 3, 14, 11, 35, 54, 389, DateTimeKind.Utc).AddTicks(8210), 1L, new DateTime(2020, 3, 15, 2, 49, 47, 27, DateTimeKind.Local).AddTicks(4600), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 389, DateTimeKind.Utc).AddTicks(8217), 1L, "Handmade Plastic Towels", -7, 5L },
                    { 5L, new DateTime(2020, 3, 14, 11, 35, 54, 387, DateTimeKind.Utc).AddTicks(3930), 2L, new DateTime(2021, 2, 23, 8, 27, 58, 783, DateTimeKind.Local).AddTicks(131), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 387, DateTimeKind.Utc).AddTicks(3937), 3L, "sexy", -14, 5L },
                    { 93L, new DateTime(2020, 3, 14, 11, 35, 54, 393, DateTimeKind.Utc).AddTicks(5217), 3L, new DateTime(2020, 8, 3, 7, 37, 41, 436, DateTimeKind.Local).AddTicks(6917), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 393, DateTimeKind.Utc).AddTicks(5221), 3L, "Latvian Lats", -6, 4L },
                    { 88L, new DateTime(2020, 3, 14, 11, 35, 54, 393, DateTimeKind.Utc).AddTicks(4876), 5L, new DateTime(2021, 1, 25, 4, 28, 53, 410, DateTimeKind.Local).AddTicks(7899), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 393, DateTimeKind.Utc).AddTicks(4880), 2L, "Triple-buffered", 10, 4L },
                    { 86L, new DateTime(2020, 3, 14, 11, 35, 54, 393, DateTimeKind.Utc).AddTicks(4762), 1L, new DateTime(2020, 10, 1, 12, 49, 50, 135, DateTimeKind.Local).AddTicks(9948), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 393, DateTimeKind.Utc).AddTicks(4766), 5L, "Walks", 8, 4L },
                    { 82L, new DateTime(2020, 3, 14, 11, 35, 54, 393, DateTimeKind.Utc).AddTicks(524), 3L, new DateTime(2020, 6, 1, 12, 23, 41, 27, DateTimeKind.Local).AddTicks(5656), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 393, DateTimeKind.Utc).AddTicks(528), 2L, "AI", 8, 4L },
                    { 74L, new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(9111), 5L, new DateTime(2020, 6, 2, 22, 0, 37, 101, DateTimeKind.Local).AddTicks(3186), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(9115), 5L, "olive", 4, 4L },
                    { 68L, new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(8742), 1L, new DateTime(2020, 10, 2, 12, 46, 19, 156, DateTimeKind.Local).AddTicks(9759), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(8745), 5L, "real-time", 2, 3L },
                    { 61L, new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(8301), 3L, new DateTime(2020, 7, 24, 14, 30, 46, 33, DateTimeKind.Local).AddTicks(8260), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(8305), 2L, "SMS", -14, 3L },
                    { 58L, new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(8132), 3L, new DateTime(2021, 3, 14, 10, 37, 55, 604, DateTimeKind.Local).AddTicks(6101), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(8136), 4L, "index", 14, 3L },
                    { 27L, new DateTime(2020, 3, 14, 11, 35, 54, 391, DateTimeKind.Utc).AddTicks(5820), 2L, new DateTime(2020, 7, 10, 14, 39, 37, 585, DateTimeKind.Local).AddTicks(6393), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 391, DateTimeKind.Utc).AddTicks(5824), 3L, "1080p", 10, 2L },
                    { 14L, new DateTime(2020, 3, 14, 11, 35, 54, 390, DateTimeKind.Utc).AddTicks(1245), 3L, new DateTime(2021, 2, 25, 21, 22, 21, 312, DateTimeKind.Local).AddTicks(9144), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 390, DateTimeKind.Utc).AddTicks(1249), 3L, "Customer-focused", -8, 2L },
                    { 12L, new DateTime(2020, 3, 14, 11, 35, 54, 390, DateTimeKind.Utc).AddTicks(1064), 2L, new DateTime(2020, 3, 29, 10, 1, 7, 923, DateTimeKind.Local).AddTicks(8704), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 390, DateTimeKind.Utc).AddTicks(1070), 1L, "Assurance", 10, 2L },
                    { 10L, new DateTime(2020, 3, 14, 11, 35, 54, 389, DateTimeKind.Utc).AddTicks(3293), 4L, new DateTime(2020, 5, 22, 8, 41, 44, 410, DateTimeKind.Local).AddTicks(833), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 389, DateTimeKind.Utc).AddTicks(3300), 5L, "hard drive", 15, 2L },
                    { 7L, new DateTime(2020, 3, 14, 11, 35, 54, 387, DateTimeKind.Utc).AddTicks(8255), 4L, new DateTime(2020, 4, 16, 0, 39, 15, 495, DateTimeKind.Local).AddTicks(2588), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 387, DateTimeKind.Utc).AddTicks(8261), 3L, "Fully-configurable", -3, 2L },
                    { 4L, new DateTime(2020, 3, 14, 11, 35, 54, 387, DateTimeKind.Utc).AddTicks(1014), 3L, new DateTime(2020, 6, 3, 7, 31, 41, 429, DateTimeKind.Local).AddTicks(6850), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 387, DateTimeKind.Utc).AddTicks(1020), 1L, "Practical", -3, 2L },
                    { 100L, new DateTime(2020, 3, 14, 11, 35, 54, 393, DateTimeKind.Utc).AddTicks(9708), 1L, new DateTime(2020, 10, 9, 9, 42, 56, 205, DateTimeKind.Local).AddTicks(9191), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 393, DateTimeKind.Utc).AddTicks(9712), 5L, "Tasty Rubber Keyboard", 0, 1L },
                    { 92L, new DateTime(2020, 3, 14, 11, 35, 54, 393, DateTimeKind.Utc).AddTicks(5132), 1L, new DateTime(2021, 1, 27, 22, 57, 50, 373, DateTimeKind.Local).AddTicks(8653), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 393, DateTimeKind.Utc).AddTicks(5136), 2L, "parse", 10, 1L },
                    { 91L, new DateTime(2020, 3, 14, 11, 35, 54, 393, DateTimeKind.Utc).AddTicks(5077), 1L, new DateTime(2020, 6, 7, 19, 37, 48, 170, DateTimeKind.Local).AddTicks(1155), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 393, DateTimeKind.Utc).AddTicks(5081), 5L, "driver", -10, 1L },
                    { 90L, new DateTime(2020, 3, 14, 11, 35, 54, 393, DateTimeKind.Utc).AddTicks(5019), 2L, new DateTime(2020, 12, 1, 7, 36, 29, 671, DateTimeKind.Local).AddTicks(6216), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 393, DateTimeKind.Utc).AddTicks(5023), 2L, "Small Cotton Keyboard", 2, 1L },
                    { 84L, new DateTime(2020, 3, 14, 11, 35, 54, 393, DateTimeKind.Utc).AddTicks(2550), 4L, new DateTime(2020, 8, 1, 10, 6, 54, 23, DateTimeKind.Local).AddTicks(3124), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 393, DateTimeKind.Utc).AddTicks(2555), 5L, "Berkshire", -11, 1L },
                    { 75L, new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(9167), 3L, new DateTime(2020, 4, 8, 19, 36, 31, 329, DateTimeKind.Local).AddTicks(2654), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(9171), 1L, "Pre-emptive", -3, 1L },
                    { 60L, new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(8245), 5L, new DateTime(2021, 2, 19, 10, 20, 8, 855, DateTimeKind.Local).AddTicks(659), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(8248), 2L, "supply-chains", -8, 1L },
                    { 57L, new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(8079), 3L, new DateTime(2020, 6, 21, 22, 14, 10, 611, DateTimeKind.Local).AddTicks(6694), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(8083), 3L, "online", 4, 1L },
                    { 56L, new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(8021), 5L, new DateTime(2020, 7, 3, 5, 38, 50, 590, DateTimeKind.Local).AddTicks(1972), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(8025), 3L, "Central", 8, 1L },
                    { 51L, new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(7715), 1L, new DateTime(2021, 2, 23, 18, 30, 5, 339, DateTimeKind.Local).AddTicks(3927), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(7719), 5L, "Implementation", 0, 1L },
                    { 49L, new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(7555), 3L, new DateTime(2021, 3, 2, 3, 37, 55, 631, DateTimeKind.Local).AddTicks(5472), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(7560), 2L, "Trafficway", 15, 1L },
                    { 37L, new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(1540), 2L, new DateTime(2020, 10, 14, 6, 2, 29, 586, DateTimeKind.Local).AddTicks(2386), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(1545), 3L, "cyan", -4, 1L },
                    { 30L, new DateTime(2020, 3, 14, 11, 35, 54, 391, DateTimeKind.Utc).AddTicks(8181), 5L, new DateTime(2020, 4, 15, 10, 24, 8, 305, DateTimeKind.Local).AddTicks(3858), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 391, DateTimeKind.Utc).AddTicks(8186), 1L, "connecting", -8, 1L },
                    { 29L, new DateTime(2020, 3, 14, 11, 35, 54, 391, DateTimeKind.Utc).AddTicks(8083), 3L, new DateTime(2020, 7, 17, 16, 32, 28, 546, DateTimeKind.Local).AddTicks(7654), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 391, DateTimeKind.Utc).AddTicks(8088), 3L, "Credit Card Account", 0, 1L },
                    { 25L, new DateTime(2020, 3, 14, 11, 35, 54, 391, DateTimeKind.Utc).AddTicks(5656), 4L, new DateTime(2020, 10, 12, 18, 19, 12, 361, DateTimeKind.Local).AddTicks(1606), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 391, DateTimeKind.Utc).AddTicks(5661), 3L, "Delaware", -1, 1L },
                    { 31L, new DateTime(2020, 3, 14, 11, 35, 54, 391, DateTimeKind.Utc).AddTicks(8274), 4L, new DateTime(2021, 2, 4, 19, 26, 55, 657, DateTimeKind.Local).AddTicks(6308), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 391, DateTimeKind.Utc).AddTicks(8278), 1L, "Incredible Wooden Shoes", -8, 2L },
                    { 32L, new DateTime(2020, 3, 14, 11, 35, 54, 391, DateTimeKind.Utc).AddTicks(9237), 2L, new DateTime(2020, 7, 19, 16, 4, 28, 914, DateTimeKind.Local).AddTicks(5105), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 391, DateTimeKind.Utc).AddTicks(9242), 4L, "Rustic Steel Pants", 13, 2L },
                    { 34L, new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(1362), 2L, new DateTime(2021, 2, 28, 2, 10, 26, 556, DateTimeKind.Local).AddTicks(7644), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(1367), 2L, "e-markets", -11, 2L },
                    { 38L, new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(1640), 3L, new DateTime(2020, 7, 14, 23, 17, 25, 43, DateTimeKind.Local).AddTicks(4333), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(1644), 4L, "Intelligent Concrete Shoes", 14, 2L },
                    { 53L, new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(7825), 3L, new DateTime(2020, 3, 21, 23, 3, 52, 337, DateTimeKind.Local).AddTicks(5364), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(7829), 5L, "Identity", -14, 3L },
                    { 50L, new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(7654), 5L, new DateTime(2020, 8, 21, 8, 10, 26, 578, DateTimeKind.Local).AddTicks(5262), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(7658), 2L, "Direct", 3, 3L },
                    { 48L, new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(5558), 1L, new DateTime(2020, 8, 24, 8, 54, 8, 741, DateTimeKind.Local).AddTicks(816), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(5562), 5L, "Brazilian Real", -6, 3L },
                    { 47L, new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(5486), 4L, new DateTime(2020, 4, 17, 21, 3, 31, 651, DateTimeKind.Local).AddTicks(2986), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(5490), 4L, "fuchsia", -3, 3L },
                    { 45L, new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(5332), 3L, new DateTime(2021, 1, 8, 21, 59, 5, 994, DateTimeKind.Local).AddTicks(82), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(5338), 2L, "bypass", 14, 3L },
                    { 35L, new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(1422), 2L, new DateTime(2020, 5, 16, 13, 29, 13, 334, DateTimeKind.Local).AddTicks(5176), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(1426), 2L, "efficient", -1, 3L },
                    { 23L, new DateTime(2020, 3, 14, 11, 35, 54, 391, DateTimeKind.Utc).AddTicks(3503), 3L, new DateTime(2021, 2, 7, 23, 8, 6, 216, DateTimeKind.Local).AddTicks(7994), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 391, DateTimeKind.Utc).AddTicks(3510), 1L, "COM", -8, 3L },
                    { 21L, new DateTime(2020, 3, 14, 11, 35, 54, 391, DateTimeKind.Utc).AddTicks(1262), 5L, new DateTime(2020, 3, 28, 16, 58, 56, 127, DateTimeKind.Local).AddTicks(5747), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 391, DateTimeKind.Utc).AddTicks(1269), 5L, "reinvent", 12, 3L },
                    { 19L, new DateTime(2020, 3, 14, 11, 35, 54, 390, DateTimeKind.Utc).AddTicks(5615), 3L, new DateTime(2020, 10, 15, 3, 10, 51, 150, DateTimeKind.Local).AddTicks(5786), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 390, DateTimeKind.Utc).AddTicks(5619), 4L, "paradigms", -14, 3L },
                    { 18L, new DateTime(2020, 3, 14, 11, 35, 54, 390, DateTimeKind.Utc).AddTicks(5516), 2L, new DateTime(2020, 8, 19, 15, 20, 3, 993, DateTimeKind.Local).AddTicks(2923), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 390, DateTimeKind.Utc).AddTicks(5522), 3L, "niches", -4, 3L },
                    { 98L, new DateTime(2020, 3, 14, 11, 35, 54, 393, DateTimeKind.Utc).AddTicks(9523), 4L, new DateTime(2020, 8, 15, 14, 48, 18, 728, DateTimeKind.Local).AddTicks(5313), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 393, DateTimeKind.Utc).AddTicks(9529), 2L, "withdrawal", 8, 5L },
                    { 13L, new DateTime(2020, 3, 14, 11, 35, 54, 390, DateTimeKind.Utc).AddTicks(1177), 4L, new DateTime(2020, 7, 18, 10, 7, 20, 288, DateTimeKind.Local).AddTicks(5125), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 390, DateTimeKind.Utc).AddTicks(1182), 5L, "mobile", 6, 3L },
                    { 8L, new DateTime(2020, 3, 14, 11, 35, 54, 388, DateTimeKind.Utc).AddTicks(7200), 3L, new DateTime(2020, 6, 11, 10, 58, 11, 454, DateTimeKind.Local).AddTicks(9913), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 388, DateTimeKind.Utc).AddTicks(7207), 3L, "Jewelery", -15, 3L },
                    { 6L, new DateTime(2020, 3, 14, 11, 35, 54, 387, DateTimeKind.Utc).AddTicks(6109), 4L, new DateTime(2020, 7, 7, 13, 38, 29, 531, DateTimeKind.Local).AddTicks(7937), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 387, DateTimeKind.Utc).AddTicks(6115), 3L, "even-keeled", 14, 3L },
                    { 2L, new DateTime(2020, 3, 14, 11, 35, 54, 386, DateTimeKind.Utc).AddTicks(5667), 3L, new DateTime(2020, 11, 17, 11, 8, 48, 716, DateTimeKind.Local).AddTicks(3976), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 386, DateTimeKind.Utc).AddTicks(5745), 5L, "haptic", -6, 3L },
                    { 85L, new DateTime(2020, 3, 14, 11, 35, 54, 393, DateTimeKind.Utc).AddTicks(4668), 2L, new DateTime(2020, 5, 12, 12, 36, 3, 107, DateTimeKind.Local).AddTicks(2349), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 393, DateTimeKind.Utc).AddTicks(4673), 4L, "conglomeration", 10, 2L },
                    { 80L, new DateTime(2020, 3, 14, 11, 35, 54, 393, DateTimeKind.Utc).AddTicks(410), 4L, new DateTime(2020, 10, 26, 6, 45, 17, 612, DateTimeKind.Local).AddTicks(2641), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 393, DateTimeKind.Utc).AddTicks(414), 5L, "Investment Account", 12, 2L },
                    { 79L, new DateTime(2020, 3, 14, 11, 35, 54, 393, DateTimeKind.Utc).AddTicks(349), 5L, new DateTime(2021, 1, 28, 18, 53, 42, 566, DateTimeKind.Local).AddTicks(8117), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 393, DateTimeKind.Utc).AddTicks(353), 1L, "SMS", 4, 2L },
                    { 70L, new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(8876), 3L, new DateTime(2020, 9, 27, 0, 40, 52, 731, DateTimeKind.Local).AddTicks(2199), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(8880), 5L, "Small Cotton Car", -4, 2L },
                    { 67L, new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(8685), 1L, new DateTime(2021, 1, 19, 0, 12, 36, 149, DateTimeKind.Local).AddTicks(2537), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(8689), 3L, "Agent", -12, 2L },
                    { 46L, new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(5428), 1L, new DateTime(2021, 1, 3, 3, 8, 40, 568, DateTimeKind.Local).AddTicks(4764), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(5432), 3L, "networks", 13, 2L },
                    { 43L, new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(3177), 2L, new DateTime(2020, 3, 22, 4, 24, 57, 947, DateTimeKind.Local).AddTicks(3281), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 392, DateTimeKind.Utc).AddTicks(3181), 4L, "Incredible Frozen Cheese", 15, 2L },
                    { 9L, new DateTime(2020, 3, 14, 11, 35, 54, 389, DateTimeKind.Utc).AddTicks(627), 2L, new DateTime(2020, 5, 14, 12, 56, 12, 513, DateTimeKind.Local).AddTicks(1279), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 389, DateTimeKind.Utc).AddTicks(634), 3L, "Mississippi", 8, 3L },
                    { 99L, new DateTime(2020, 3, 14, 11, 35, 54, 393, DateTimeKind.Utc).AddTicks(9623), 2L, new DateTime(2020, 11, 26, 3, 4, 35, 959, DateTimeKind.Local).AddTicks(7159), "", "", new DateTime(2020, 3, 14, 11, 35, 54, 393, DateTimeKind.Utc).AddTicks(9628), 4L, "Response", 0, 5L }
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
