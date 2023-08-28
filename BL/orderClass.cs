using System;
using System.Collections.Generic;
using System.Data;
using Oracle.ManagedDataAccess.Client;
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


        public DataTable GET_LAST_RETURN_ID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();

            using (OracleDataAdapter reader = DAL.SelectData("LAST_RETURN_ID.GET_LAST_RETURN_ID", "CUR_LAST_RETURN_ID"))
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




        public void ADD_RETURN(DateTime v_returnDate,string v_retDescription, int v_originInvoId,decimal v_totalAmount,int v_returnNumber)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            OracleParameter[] param = new OracleParameter[5];

            param[0] = new OracleParameter(" v_returnDate", OracleDbType.Date);
            param[0].Value = v_returnDate;

            param[1] = new OracleParameter("v_retDescription", OracleDbType.Varchar2);
            param[1].Value = v_retDescription;

            param[2] = new OracleParameter("v_originInvoId", OracleDbType.Int32);
            param[2].Value = v_originInvoId;

            param[3] = new OracleParameter("v_totalAmount", OracleDbType.Decimal);
            param[3].Value = v_totalAmount;


            param[4] = new OracleParameter("v_returnNumber", OracleDbType.Int32);
            param[4].Value = v_returnNumber;


            DAL.ExecuteCommand("INSERT_RETURN", param);
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


        public void UPDATE_RETUREDINVOICEITEM(int status, int lineItemId)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            OracleParameter[] param = new OracleParameter[2];

            param[0] = new OracleParameter("v_status", OracleDbType.Int32);
            param[0].Value = status;


            param[1] = new OracleParameter("v_linId", OracleDbType.Int32);
            param[1].Value = lineItemId;

            DAL.ExecuteCommand("EDITE_RETURNEDINVOICEITEM", param);
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


        public DataTable GET_ALL_Main_INVOICES_DETAILS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();

            using (OracleDataAdapter reader = DAL.SelectData("AllMainInvoiceDetails.GET_ALLINVOICES", "CUR_ALLINVOICES"))
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


        public DataTable GETINVOICEDETAILSFORPRINT(int invoiceId)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();

            using (OracleDataAdapter reader = DAL.SelectDataById("GetInvoiceDetailsForPrint", "p_invoiceId", "p_cursor", invoiceId))
            {
                reader.Fill(dt);
            }

            return dt;
        }

        public DataTable GETORDERDETAILSFORPRINT(int orderId)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();

            using (OracleDataAdapter reader = DAL.SelectDataById("GetOrderDetailsForPrint", "p_orderId", "p_cursor", orderId))
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

        public void UPDATE_PURCHASEORDER_UPDATEBTN(int vendorId, DateTime orderDate,string deliveryAddress,string description,int orderId)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            OracleParameter[] param = new OracleParameter[5];

            param[0] = new OracleParameter("v_vendorId", OracleDbType.Int32);
            param[0].Value = vendorId;

            param[1] = new OracleParameter("v_orderDate", OracleDbType.Date);
            param[1].Value = orderDate;


            param[2] = new OracleParameter("v_deliveryAddress", OracleDbType.Varchar2);
            param[2].Value = deliveryAddress;


            param[3] = new OracleParameter("v_description", OracleDbType.Varchar2);
            param[3].Value = description;


            param[4] = new OracleParameter("v_orderId", OracleDbType.Int32);
            param[4].Value = orderId;

            DAL.ExecuteCommand("EDITE_PURCHASEORDER_UPDATEBTN", param);
            DAL.Close();

        }


        public void UPDATE_ORDERLINE_UPDATEBTN(int productId, int  qty,  int lineId)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            OracleParameter[] param = new OracleParameter[3];

            param[0] = new OracleParameter("v_productId", OracleDbType.Int32);
            param[0].Value = productId;

            param[1] = new OracleParameter("v_quantity", OracleDbType.Int32);
            param[1].Value = qty;


            param[2] = new OracleParameter("v_lineId", OracleDbType.Int32);
            param[2].Value = lineId;



            DAL.ExecuteCommand("EDITE_ORDERLINE_UPDATEBTN", param);
            DAL.Close();

        }


        public void UPDATE_INVOICE_UPDATEBTN(int v_orderId, int v_invoiceNumber, DateTime v_invoiceDate, decimal v_amount,DateTime v_dueDate,
            string v_description, string v_payementMethod,
            string v_currency,int v_vendorInvoice, int v_invoiceId)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            OracleParameter[] param = new OracleParameter[10];

            param[0] = new OracleParameter("v_orderId", OracleDbType.Int32);
            param[0].Value = v_orderId;

            param[1] = new OracleParameter("v_invoiceNumber", OracleDbType.Int32);
            param[1].Value = v_invoiceNumber;

            param[2] = new OracleParameter("v_invoiceDate", OracleDbType.Date);
            param[2].Value = v_invoiceDate;

            param[3] = new OracleParameter("v_amount", OracleDbType.Decimal);
            param[3].Value = v_amount;

            param[4] = new OracleParameter("v_dueDate", OracleDbType.Date);
            param[4].Value = v_dueDate;


            param[5] = new OracleParameter("v_description", OracleDbType.Varchar2);
            param[5].Value = v_description;


            param[6] = new OracleParameter("v_payementMethod", OracleDbType.Varchar2);
            param[6].Value = v_payementMethod;

            param[7] = new OracleParameter("v_currency", OracleDbType.Varchar2);
            param[7].Value = v_currency;

            param[8] = new OracleParameter("v_vendorInvoice", OracleDbType.Int32);
            param[8].Value = v_vendorInvoice;


            param[9] = new OracleParameter("v_invoiceId", OracleDbType.Int32);
            param[9].Value = v_invoiceId;



            DAL.ExecuteCommand("UPDATE_INVOICE", param);
            DAL.Close();

        }




    }
}
