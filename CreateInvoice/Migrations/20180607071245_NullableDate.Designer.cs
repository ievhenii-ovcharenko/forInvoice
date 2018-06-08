﻿// <auto-generated />
using CreateInvoice.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace CreateInvoice.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20180607071245_NullableDate")]
    partial class NullableDate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CreateInvoice.Entities.Certificate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("EndDate");

                    b.Property<string>("Name");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasFilter("[Name] IS NOT NULL");

                    b.ToTable("Certificates");
                });

            modelBuilder.Entity("CreateInvoice.Entities.CertificateCountry", b =>
                {
                    b.Property<int>("CertificateId");

                    b.Property<int>("CountryId");

                    b.HasKey("CertificateId", "CountryId");

                    b.HasIndex("CountryId");

                    b.ToTable("CertificateCountry");
                });

            modelBuilder.Entity("CreateInvoice.Entities.ContactDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ContactTypeId");

                    b.Property<string>("Name");

                    b.Property<int?>("OrganizationId");

                    b.HasKey("Id");

                    b.HasIndex("ContactTypeId");

                    b.HasIndex("OrganizationId");

                    b.ToTable("ContactDetails");
                });

            modelBuilder.Entity("CreateInvoice.Entities.ContactType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("ContactTypes");
                });

            modelBuilder.Entity("CreateInvoice.Entities.Contract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BuyerId");

                    b.Property<string>("Name");

                    b.Property<int?>("SellerId");

                    b.HasKey("Id");

                    b.HasIndex("BuyerId");

                    b.HasIndex("SellerId");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("CreateInvoice.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DescriptionEn");

                    b.Property<string>("DescriptionUa");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("CreateInvoice.Entities.DeliveryType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("DeliveryTypes");
                });

            modelBuilder.Entity("CreateInvoice.Entities.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BuyerId");

                    b.Property<int?>("ContractId");

                    b.Property<DateTime>("Date");

                    b.Property<int?>("DeliveryTypeId");

                    b.Property<string>("InvoiceNo");

                    b.Property<string>("OrderNo");

                    b.Property<string>("PaymentIdentification");

                    b.Property<int?>("SellerId");

                    b.Property<int?>("TermOfPaymentId");

                    b.Property<int?>("TermsOfDeliveryId");

                    b.HasKey("Id");

                    b.HasIndex("BuyerId");

                    b.HasIndex("ContractId");

                    b.HasIndex("DeliveryTypeId");

                    b.HasIndex("SellerId");

                    b.HasIndex("TermOfPaymentId");

                    b.HasIndex("TermsOfDeliveryId");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("CreateInvoice.Entities.InvoiceProducts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("InvoiceId");

                    b.Property<int?>("ProductId");

                    b.Property<int>("ProductPosition");

                    b.Property<int>("Quantity");

                    b.Property<double>("UnitPrice");

                    b.HasKey("Id");

                    b.HasIndex("InvoiceId");

                    b.HasIndex("ProductId");

                    b.ToTable("InvoiceProducts");
                });

            modelBuilder.Entity("CreateInvoice.Entities.Organization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Organizations");
                });

            modelBuilder.Entity("CreateInvoice.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CertificateId");

                    b.Property<string>("CodeNo");

                    b.Property<int?>("CountryOfOriginId");

                    b.Property<string>("DescriptionEn");

                    b.Property<string>("DescriptionUa");

                    b.HasKey("Id");

                    b.HasIndex("CertificateId");

                    b.HasIndex("CodeNo");

                    b.HasIndex("CountryOfOriginId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("CreateInvoice.Entities.TermOfPayment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("TermsOfPayment");
                });

            modelBuilder.Entity("CreateInvoice.Entities.TermsOfDelivery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("TermsOfDelivery");
                });

            modelBuilder.Entity("CreateInvoice.Entities.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Units");
                });

            modelBuilder.Entity("CreateInvoice.Entities.CertificateCountry", b =>
                {
                    b.HasOne("CreateInvoice.Entities.Certificate", "Certificate")
                        .WithMany("CertificateCountries")
                        .HasForeignKey("CertificateId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CreateInvoice.Entities.Country", "Country")
                        .WithMany("CountryCertificates")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CreateInvoice.Entities.ContactDetails", b =>
                {
                    b.HasOne("CreateInvoice.Entities.ContactType", "ContactType")
                        .WithMany()
                        .HasForeignKey("ContactTypeId");

                    b.HasOne("CreateInvoice.Entities.Organization", "Organization")
                        .WithMany()
                        .HasForeignKey("OrganizationId");
                });

            modelBuilder.Entity("CreateInvoice.Entities.Contract", b =>
                {
                    b.HasOne("CreateInvoice.Entities.Organization", "Buyer")
                        .WithMany()
                        .HasForeignKey("BuyerId");

                    b.HasOne("CreateInvoice.Entities.Organization", "Seller")
                        .WithMany()
                        .HasForeignKey("SellerId");
                });

            modelBuilder.Entity("CreateInvoice.Entities.Invoice", b =>
                {
                    b.HasOne("CreateInvoice.Entities.Organization", "Buyer")
                        .WithMany()
                        .HasForeignKey("BuyerId");

                    b.HasOne("CreateInvoice.Entities.Contract", "Contract")
                        .WithMany()
                        .HasForeignKey("ContractId");

                    b.HasOne("CreateInvoice.Entities.DeliveryType", "DeliveryType")
                        .WithMany()
                        .HasForeignKey("DeliveryTypeId");

                    b.HasOne("CreateInvoice.Entities.Organization", "Seller")
                        .WithMany()
                        .HasForeignKey("SellerId");

                    b.HasOne("CreateInvoice.Entities.TermOfPayment", "TermOfPayment")
                        .WithMany()
                        .HasForeignKey("TermOfPaymentId");

                    b.HasOne("CreateInvoice.Entities.TermsOfDelivery", "TermsOfDelivery")
                        .WithMany()
                        .HasForeignKey("TermsOfDeliveryId");
                });

            modelBuilder.Entity("CreateInvoice.Entities.InvoiceProducts", b =>
                {
                    b.HasOne("CreateInvoice.Entities.Invoice", "Invoice")
                        .WithMany()
                        .HasForeignKey("InvoiceId");

                    b.HasOne("CreateInvoice.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("CreateInvoice.Entities.Product", b =>
                {
                    b.HasOne("CreateInvoice.Entities.Certificate", "Certificate")
                        .WithMany()
                        .HasForeignKey("CertificateId");

                    b.HasOne("CreateInvoice.Entities.Country", "CountryOfOrigin")
                        .WithMany()
                        .HasForeignKey("CountryOfOriginId");
                });
#pragma warning restore 612, 618
        }
    }
}
