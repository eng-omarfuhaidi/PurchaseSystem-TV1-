﻿using System;
using System.Collections.Generic;
using System.Data;
using Oracle.DataAccess.Client;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseSystem.BL
{
    class orderClass
    {

        public DataTable GET_LAST_ORDER_ID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();

            using (OracleDataAdapter reader = DAL.SelectData("LAST_ORDER_ID.GET_LAST_ORDER_ID", "CUR_LAST_ORDER_ID"))
            {
                reader.Fill(dt);
            }

            return dt;
        }


        public DataTable GET_RLAST_ORDER_ID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();

            using (OracleDataAdapter reader = DAL.SelectData("RLAST_ORDER_ID.GET_RLAST_ORDER_ID", "CUR_RLAST_ORDER_ID"))
            {
                reader.Fill(dt);
            }

            return dt;
        }

        public DataTable GET_LAST_INVOICE_ID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();

            using (OracleDataAdapter reader = DAL.SelectData("LAST_INVOICE_ID.GET_LAST_INVOICE_ID", "CUR_LAST_INVOICE_ID"))
            {
                reader.Fill(dt);
            }

            return dt;
        }


        public void ADD_ORDER(int vendorId,int orderNumber, DateTime orderDate, string deliveryAddress,
                          string description)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            OracleParameter[] param = new OracleParameter[5];

            param[0] = new OracleParameter(" v_Id", OracleDbType.Int32);
            param[0].Value = vendorId;

            param[1] = new OracleParameter("v_oderNumber", OracleDbType.Int32);
            param[1].Value = orderNumber;

            param[2] = new OracleParameter("v_oderDate", OracleDbType.Date);
            param[2].Value = orderDate;

            param[3] = new OracleParameter("v_deliveryAddress", OracleDbType.Varchar2,255);
            param[3].Value = deliveryAddress;

            param[4] = new OracleParameter("v_description", OracleDbType.Varchar2,255);
            param[4].Value = description;
            DAL.ExecuteCommand("INSERT_ORDER", param);
            DAL.Close();

        }


        public void ADD_ORDERITEM(int orderId, int productId, int quantity)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            OracleParameter[] param = new OracleParameter[3];

            param[0] = new OracleParameter(" v_orderId", OracleDbType.Int32);
            param[0].Value = orderId;

            param[1] = new OracleParameter("v_productId", OracleDbType.Int32);
            param[1].Value = productId;

            param[2] = new OracleParameter("v_quantity", OracleDbType.Int32);
            param[2].Value = quantity;

            DAL.ExecuteCommand("INSERT_ORDERITEM", param);
            DAL.Close();

        }


        public void ADD_INVOICE(int orderId, int invoiceNumber, DateTime invoiceDate, decimal amount,DateTime dueDAte,string description
            ,string paymentMethod,string currency,int vendorInvoiceNumber)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            OracleParameter[] param = new OracleParameter[9];

            param[0] = new OracleParameter(" v_orderId", OracleDbType.Int32);
            param[0].Value = orderId;

            param[1] = new OracleParameter("v_invoiceNumber", OracleDbType.Int32);
            param[1].Value = invoiceNumber;

            param[2] = new OracleParameter("v_invoiceDate", OracleDbType.Date);
            param[2].Value = invoiceDate;

            param[3] = new OracleParameter("v_amount", OracleDbType.Decimal);
            param[3].Value = amount;


            param[4] = new OracleParameter("v_dueDate", OracleDbType.Date);
            param[4].Value = dueDAte;


            param[5] = new OracleParameter("v_description", OracleDbType.Varchar2, 255);
            param[5].Value = description;

            param[6] = new OracleParameter("v_paymentMethod", OracleDbType.Varchar2,20);
            param[6].Value = paymentMethod;

            param[7] = new OracleParameter("v_currency", OracleDbType.Varchar2, 20);
            param[7].Value = currency;

            param[8] = new OracleParameter("v_vendorInvoice", OracleDbType.Int32);
            param[8].Value = vendorInvoiceNumber;

            DAL.ExecuteCommand("INSERT_INVOICE", param);
            DAL.Close();

        }



        public void UPDATE_PURCHASEORDERLIINE(int quantity, decimal unitPrice, decimal totalAmount,
                        int lineId)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            OracleParameter[] param = new OracleParameter[4];

            param[0] = new OracleParameter("v_quantity", OracleDbType.Int32);
            param[0].Value = quantity;

            param[1] = new OracleParameter("v_unitPrice", OracleDbType.Decimal);
            param[1].Value = unitPrice;

            param[2] = new OracleParameter("v_totalAmount", OracleDbType.Decimal);
            param[2].Value = totalAmount;


            param[3] = new OracleParameter("v_lineId", OracleDbType.Int32);
            param[3].Value = lineId;

            DAL.ExecuteCommand("EDITE_PURCHASEORDERLINE", param);
            DAL.Close();

        }




        public void UPDATE_PURCHASEORDER(int status,  int orderId)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            OracleParameter[] param = new OracleParameter[2];

            param[0] = new OracleParameter("v_status", OracleDbType.Int32);
            param[0].Value = status;


            param[1] = new OracleParameter("v_orderId", OracleDbType.Int32);
            param[1].Value = orderId;

            DAL.ExecuteCommand("EDITE_PURCHASEORDER", param);
            DAL.Close();

        }




        public DataTable GET_ALL_ORDERS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();

            using (OracleDataAdapter reader = DAL.SelectData("ORDERS.GET_ORDER", "CUR_ORDER"))
            {
                reader.Fill(dt);
            }

            return dt;
        }

        public DataTable GET_ALL_Main_ORDERS_DETAILS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();

            using (OracleDataAdapter reader = DAL.SelectData("AllMainOdersDetails.GET_ALLORDERS", "CUR_ALLORDERS"))
            {
                reader.Fill(dt);
            }

            return dt;
        }


        public DataTable GET_ORDERDETAILS_BYID(int orderId)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();

            using (OracleDataAdapter reader = DAL.SelectDataById("GetOrderLineData", "p_orderId", "p_cursor",orderId))
            {
                reader.Fill(dt);
            }

            return dt;
        }


        public DataTable Fill_InvoiceCombo()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();

            using (OracleDataAdapter reader = DAL.PopoulateCombo("Invoice_number.GET_INVOICENUMBER", "CUR_INVOICENUMBER"))
            {
                reader.Fill(dt);
            }

            return dt;
        }


        public DataTable GET_MAININVOICEDETAILS_BYID(int invoiceId)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();

            using (OracleDataAdapter reader = DAL.SelectDataById("GetMainInviceDetailsBYID", "p_invoiceId", "p_cursor", invoiceId))
            {
                reader.Fill(dt);
            }

            return dt;
        }





        public DataTable GetSecInviceDetailsBYID(int invoiceId) 
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();

            using (OracleDataAdapter reader = DAL.SelectDataById("GetSecInviceDetailsBYID", "p_invoiceId", "p_cursor", invoiceId))
            {
                reader.Fill(dt);
            }

            return dt;
        }



        public DataTable GET_MAINORDERDETAILS_BYID(int invoiceId)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();

            using (OracleDataAdapter reader = DAL.SelectDataById("GetMainOrderDetailsBYID", "p_orderId", "p_cursor", invoiceId))
            {
                reader.Fill(dt);
            }

            return dt;
        }

    }
}
