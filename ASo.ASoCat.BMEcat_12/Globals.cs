using System;
using System.Xml;

namespace ASo.ASoCat.BMEcat_12
{
    public static class Globals
    {
        #region XML Reader/Writer

        /// <summary>
        /// XML reader object.
        /// </summary>
        public static XmlReader ObjectReader;

        /// <summary>
        /// XML writer object.
        /// </summary>
        public static XmlWriter ObjectWriter;

        #endregion

        #region Catalog element names

        /// <summary>
        /// Catalog element ADDRESS
        /// </summary>
        public const string CatElementAddress = "ADDRESS"; //Properties.Resources.CatElementAddress; //  "CatElementADDRESS";

        /// <summary>
        /// Catalog element ADDRESS_REMARKS
        /// </summary>
        public const string CatElementAddressRemarks = "ADDRESS_REMARKS";

        /// <summary>
        /// Catalog element AGREEMENT
        /// </summary>
        public const string CatElementAgreement = "AGREEMENT";

        /// <summary>
        /// Catalog element AGREEMENT_ID
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string CatElementAgreementID = "AGREEMENT_ID";

        /// <summary>
        /// Catalog element ALLOWED_VALUE
        /// </summary>
        public const string CatElementAllowedValue = "ALLOWED_VALUE";

        /// <summary>
        /// Catalog element ALLOWED_VALUES
        /// </summary>
        public const string CatElementAllowedValues = "ALLOWED_VALUES";

        /// <summary>
        /// Catalog element ALLOWED_VALUE_DESCR
        /// </summary>
        public const string CatElementALLOWED_VALUE_DESCR = "ALLOWED_VALUE_DESCR";

        /// <summary>
        /// Catalog element ALLOWED_VALUE_ID
        /// </summary>
        public const string CatElementALLOWED_VAUE_ID = "ALLOWED_VALUE_ID";

        /// <summary>
        /// Catalog element ALLOWED_VALUE_IDREF
        /// </summary>
        public const string CatElementALLOWED_VALUE_IDREF = "ALLOWED_VALUE_IDREF";

        /// <summary>
        /// Catalog element ALLOWED_VALUE_NAME
        /// </summary>
        public const string CatElementALLOWED_VALUE_NAME = "ALLOWED_VALUE_NAME";

        /// <summary>
        /// Catalog element ARTICLE
        /// </summary>
        public const string CatElementARTICLE = "ARTICLE";

        /// <summary>
        /// Catalog element ARTICLE_DETAILS
        /// </summary>
        public const string CatElementARTICLE_DETAILS = "ARTICLE_DETAILS";

        /// <summary>
        /// Catalog element ARTICLE_FEATURES
        /// </summary>
        public const string CatElementARTICLE_FEATURES = "ARTICLE_FEATURES";

        /// <summary>
        /// Catalog element ARTICLE_ORDER
        /// </summary>
        public const string CatElementARTICLE_ORDER = "ARTICLE_ORDER";


        /// <summary>
        /// Catalog element ARTICLE_ORDER_DETAILS
        /// </summary>
        public const string CatElementARTICLE_ORDER_DETAILS = "ARTICLE_ORDER_DETAILS";

        /// <summary>
        /// Catalog element ARTICLE_PRICE
        /// </summary>
        public const string CatElementARTICLE_PRICE = "ARTICLE_PRICE";

        /// <summary>
        /// Catalog element ARTICLE_PRICE_DETAILS
        /// </summary>
        public const string CatElementARTICLE_PRICE_DETAILS = "ARTICLE_PRICE";

        /// <summary>
        /// Catalog element ARTICLE_REFERENCE
        /// </summary>
        public const string CatElementARTICLE_REFERENCE = "ARTICLE_REFERENCE";

        /// <summary>
        /// Catalog element ARTICLE_STATUS
        /// </summary>
        public const string CatElementARTICLE_STATUS = "ARTICLE_STATUS";

        /// <summary>
        /// Catalog element ARTICLE_TO_CATALOGGROUP_MAP
        /// </summary>
        public const string CatElementARTICLE_TO_CATALOGGROUP_MAP = "ARTICLE_TO_CATALOGGROUP_MAP";

        /// <summary>
        /// Catalog element ARTICLE_TO_CATALOGGROUP_MAP_ORDER
        /// </summary>
        public const string CatElementARTICLE_TO_CATALOGGROUP_MAP_ORDER = "ARTICLE_TO_CATALOGGROUP_MAP_ORDER";

        /// <summary>
        /// Catalog element ART_ID
        /// </summary>
        public const string CatElementART_ID = "ART_ID";

        /// <summary>
        /// Catalog element ART_ID_TO
        /// </summary>
        public const string CatElementART_ID_TO = "ART_ID_TO";

        /// <summary>
        /// Catalog element BMECAT
        /// </summary>
        public const string CatElementBMECAT = "BMECAT";

        /// <summary>
        /// Catalog element BMECAT_DATA
        /// </summary>
        public const string CatElementBMECAT_DATA = "BMECAT_DATA";

        /// <summary>
        /// Catalog element BMECAT_FILE
        /// </summary>
        public const string CatElementBMECAT_FILE = "BMECAT_FILE";

        /// <summary>
        /// Catalog element BOXNO
        /// </summary>
        public const string CatElementBOXNO = "BOXNO";

        /// <summary>
        /// Catalog element BUYER
        /// </summary>
        public const string CatElementBUYER = "BUYER";

        /// <summary>
        /// Catalog element BUYER_AID
        /// </summary>
        public const string CatElementBUYER_AID = "BUYER_AID";

        /// <summary>
        /// Catalog element BUYER_ID
        /// </summary>
        public const string CatElementBUYER_ID = "BUYER_ID";

        /// <summary>
        /// Catalog element BUYER_NAME
        /// </summary>
        public const string CatElementBUYER_NAME = "BUYER_NAME";

        /// <summary>
        /// Catalog element CATALOG
        /// </summary>
        public const string CatElementCATALOG = "CATALOG";

        /// <summary>
        /// Catalog element CATALOG_GROUP_ID
        /// </summary>
        public const string CatElementCATALOG_GROUP_ID = "CATALOG_GROUP_ID";

        /// <summary>
        /// Catalog element CATALOG_GROUP_SYSTEM
        /// </summary>
        public const string CatElementCATALOG_GROUP_SYSTEM = "CATALOG_GROUP_SYSTEM";

        /// <summary>
        /// Catalog element CATALOG_ID
        /// </summary>
        public const string CatElementCATALOG_ID = "CATALOG_ID";

        /// <summary>
        /// Catalog element CATALOG_NAME
        /// </summary>
        public const string CatElementCATALOG_NAME = "CATALOG_NAME";

        /// <summary>
        /// Catalog element CATALOG_STRUCTURE
        /// </summary>
        public const string CatElementCATALOG_STRUCTURE = "CATALOG_STRUCTURE";

        /// <summary>
        /// Catalog element CATALOG_VERSION
        /// </summary>
        public const string CatElementCATALOG_VERSION = "CATALOG_VERSION";

        /// <summary>
        /// Catalog element CITY
        /// </summary>
        public const string CatElementCITY = "CITY";

        /// <summary>
        /// Catalog element CLASSIFICATION_GROUP
        /// </summary>
        public const string CatElementCLASSIFICATION_GROUP = "CLASSIFICATION_GROUP";

        /// <summary>
        /// Catalog element CLASSIFICATION_GROUPS
        /// </summary>
        public const string CatElementCLASSIFICATION_GROUPS = "CLASSIFICATION_GROUPS";

        /// <summary>
        /// Catalog element CLASSIFICATION_GROUP_DESCR
        /// </summary>
        public const string CatElementCLASSIFICATION_GROUP_DESCR = "CLASSIFICATION_GROUP_DESCR";

        /// <summary>
        /// Catalog element CLASSIFICATION_GROUP_FEATURE_TEMPLATE
        /// </summary>
        public const string CatElementCLASSIFICATION_GROUP_FEATURE_TEMPLATE = "CLASSIFICATION_GROUP_FEATURE_TEMPLATE";

        /// <summary>
        /// Catalog element CLASSIFICATION_GROUP_FEATURE_TEMPLATES
        /// </summary>
        public const string CatElementCLASSIFICATION_GROUP_FEATURE_TEMPLATES = "CLASSIFICATION_GROUP_FEATURE_TEMPLATES";

        /// <summary>
        /// Catalog element CLASSIFICATION_GROUP_ID
        /// </summary>
        public const string CatElementCLASSIFICATION_GROUP_ID = "CLASSIFICATION_GROUP_ID";

        /// <summary>
        /// Catalog element CLASSIFICATION_GROUP_NAME
        /// </summary>
        public const string CatElementCLASSIFICATION_GROUP_NAME = "CLASSIFICATION_GROUP_NAME";

        /// <summary>
        /// Catalog element CLASSIFICATION_GROUP_PARENT_ID
        /// </summary>
        public const string CatElementCLASSIFICATION_GROUP_PARENT_ID = "CLASSIFICATION_GROUP_PARENT_ID";

        /// <summary>
        /// Catalog element CLASSIFICATION_GROUP_SYNONYMS
        /// </summary>
        public const string CatElementCLASSIFICATION_GROUP_SYNONYMS = "CLASSIFICATION_GROUP_SYNONYMS";

        /// <summary>
        /// Catalog element CLASSIFICATION_SYSTEM
        /// </summary>
        public const string CatElementCLASSIFICATION_SYSTEM = "CLASSIFICATION_SYSTEM";

        /// <summary>
        /// Catalog element CLASSIFICATION_SYSTEM_DESCR
        /// </summary>
        public const string CatElementCLASSIFICATION_SYSTEM_DESCR = "CLASSIFICATION_SYSTEM_DESCR";

        /// <summary>
        /// Catalog element CLASSIFICATION_SYSTEM_FEATURE_TEMPLATE
        /// </summary>
        public const string CatElementCLASSIFICATION_SYSTEM_FEATURE_TEMPLATE = "CLASSIFICATION_SYSTEM_FEATURE_TEMPLATE";

        /// <summary>
        /// Catalog element CLASSIFICATION_SYSTEM_FEATURE_TEMPLATES
        /// </summary>
        public const string CatElementCLASSIFICATION_SYSTEM_FEATURE_TEMPLATES =
            "CLASSIFICATION_SYSTEM_FEATURE_TEMPLATES";

        /// <summary>
        /// Catalog element CLASSIFICATION_SYSTEM_FULLNAME
        /// </summary>
        public const string CatElementCLASSIFICATION_SYSTEM_FULLNAME = "CLASSIFICATION_SYSTEM_FULLNAME";

        /// <summary>
        /// Catalog element CLASSIFICATION_SYSTEM_LEVELS
        /// </summary>
        public const string CatElementCLASSIFICATION_SYSTEM_LEVELS = "CLASSIFICATION_SYSTEM_LEVELS";

        /// <summary>
        /// Catalog element CLASSIFICATION_SYSTEM_LEVEL_NAME
        /// </summary>
        public const string CatElementCLASSIFICATION_SYSTEM_LEVEL_NAME = "CLASSIFICATION_SYSTEM_LEVEL_NAME";

        /// <summary>
        /// Catalog element CLASSIFICATION_SYSTEM_LEVEL_NAMES
        /// </summary>
        public const string CatElementCLASSIFICATION_SYSTEM_LEVEL_NAMES = "CLASSIFICATION_SYSTEM_LEVEL_NAMES";

        /// <summary>
        /// Catalog element CLASSIFICATION_SYSTEM_NAME
        /// </summary>
        public const string CatElementCLASSIFICATION_SYSTEM_NAME = "CLASSIFICATION_SYSTEM_NAME";

        /// <summary>
        /// Catalog element CLASSIFICATION_SYSTEM_VERSION
        /// </summary>
        public const string CatElementCLASSIFICATION_SYSTEM_VERSION = "CLASSIFICATION_SYSTEM_VERSION";

        /// <summary>
        /// Catalog element CONTACT
        /// </summary>
        public const string CatElementCONTACT = "CONTACT";

        /// <summary>
        /// Catalog element CONTENT_UNIT
        /// </summary>
        public const string CatElementCONTENT_UNIT = "CONTENT_UNIT";

        /// <summary>
        /// Catalog element COUNTRY
        /// </summary>
        public const string CatElementCOUNTRY = "COUNTRY";

        /// <summary>
        /// Catalog element CURRENCY
        /// </summary>
        public const string CatElementCURRENCY = "CURRENCY";

        /// <summary>
        /// Catalog element DAILY_PRICE
        /// </summary>
        public const string CatElementDAILY_PRICE = "DAILY_PRICE";

        /// <summary>
        /// Catalog element DATE
        /// </summary>
        public const string CatElementDATE = "DATE";

        /// <summary>
        /// Catalog element DATETIME
        /// </summary>
        public const string CatElementDATETIME = "DATETIME";

        /// <summary>
        /// Catalog element DELIVERY_TIME
        /// </summary>
        public const string CatElementDELIVERY_TIME = "DELIVERY_TIME";

        /// <summary>
        /// Catalog element DESCRIPTION_LONG
        /// </summary>
        public const string CatElementDESCRIPTION_LONG = "DESCRIPTION_LONG";

        /// <summary>
        /// Catalog element DESCRIPTION_SHORT
        /// </summary>
        public const string CatElementDESCRIPTION_SHORT = "DESCRIPTION_SHORT";

        /// <summary>
        /// Catalog element DOCTYPE
        /// </summary>
        public const string CatElementDOCTYPE = "DOCTYPE";

        /// <summary>
        /// Catalog element EAN
        /// </summary>
        public const string CatElementEAN = "EAN";

        /// <summary>
        /// Catalog element EMAIL
        /// </summary>
        public const string CatElementEMAIL = "EMAIL";

        /// <summary>
        /// Catalog element ERP_GROUP_BUYER
        /// </summary>
        public const string CatElementERP_GROUP_BUYER = "ERP_GROUP_BUYER";

        /// <summary>
        /// Catalog element ERP_GROUP_SUPPLIER
        /// </summary>
        public const string CatElementERP_GROUP_SUPPLIER = "ERP_GROUP_SUPPLIER";

        /// <summary>
        /// Catalog element FAX
        /// </summary>
        public const string CatElementFAX = "FAX";

        /// <summary>
        /// Catalog element FDESCR
        /// </summary>
        public const string CatElementFDESCR = "FDESCR";

        /// <summary>
        /// Catalog element FEATURE
        /// </summary>
        public const string CatElementFEATURE = "FEATURE";

        /// <summary>
        /// Catalog element FEATURE_GROUP
        /// </summary>
        public const string CatElementFEATURE_GROUP = "FEATURE_GROUP";

        /// <summary>
        /// Catalog element FEATURE_GROUP_DESCR
        /// </summary>
        public const string CatElementFEATURE_GROUP_DESCR = "FEATURE_GROUP_DESCR";

        /// <summary>
        /// Catalog element FEATURE_GROUP_ID
        /// </summary>
        public const string CatElementFEATURE_GROUP_ID = "FEATURE_GROUP_ID";

        /// <summary>
        /// Catalog element FEATURE_GROUP_NAME
        /// </summary>
        public const string CatElementFEATURE_GROUP_NAME = "FEATURE_GROUP_NAME";

        /// <summary>
        /// Catalog element FEATURE_SYSTEM
        /// </summary>
        public const string CatElementFEATURE_SYSTEM = "FEATURE_SYSTEM";

        /// <summary>
        /// Catalog element FEATURE_SYSTEM_DESCR
        /// </summary>
        public const string CatElementFEATURE_SYSTEM_DESCR = "FEATURE_SYSTEM_DESCR";

        /// <summary>
        /// Catalog element FEATURE_SYSTEM_NAME
        /// </summary>
        public const string CatElementFEATURE_SYSTEM_NAME = "FEATURE_SYSTEM_NAME";

        /// <summary>
        /// Catalog element FEATURE_TEMPLATE
        /// </summary>
        public const string CatElementFEATURE_TEMPLATE = "FEATURE_TEMPLATE";

        /// <summary>
        /// Catalog element FNAME
        /// </summary>
        public const string CatElementFNAME = "FNAME";

        /// <summary>
        /// Catalog element FORDER
        /// </summary>
        public const string CatElementFORDER = "FORDER";

        /// <summary>
        /// Catalog element FT_ALLOWED_VALUES
        /// </summary>
        public const string CatElementFT_ALLOWED_VALUES = "FT_ALLOWED_VALUES";

        /// <summary>
        /// Catalog element FT_DATATYPE
        /// </summary>
        public const string CatElementFT_DATATYPE = "FT_DATATYPE";

        /// <summary>
        /// Catalog element FT_DESCR
        /// </summary>
        public const string CatElementFT_DESCR = "FT_DESCR";

        /// <summary>
        /// Catalog element FT_ID
        /// </summary>
        public const string CatElementFT_ID = "FT_ID";

        /// <summary>
        /// Catalog element FT_IDREF
        /// </summary>
        public const string CatElementFT_IDREF = "FT_IDREF";

        /// <summary>
        /// Catalog element FT_MANDATORY
        /// </summary>
        public const string CatElementFT_MANDATORY = "FT_MANDATORY";

        /// <summary>
        /// Catalog element FT_NAME
        /// </summary>
        public const string CatElementFT_NAME = "FT_NAME";

        /// <summary>
        /// Catalog element FT_ORDER
        /// </summary>
        public const string CatElementFT_ORDER = "FT_ORDER";

        /// <summary>
        /// Catalog element FT_UNIT
        /// </summary>
        public const string CatElementFT_UNIT = "FT_UNIT";

        /// <summary>
        /// Catalog element FUNIT
        /// </summary>
        public const string CatElementFUNIT = "FUNIT";

        /// <summary>
        /// Catalog element FVALUE
        /// </summary>
        public const string CatElementFVALUE = "FVALUE";

        /// <summary>
        /// Catalog element FVALUE_DETAILS
        /// </summary>
        public const string CatElementFVALUE_DETAILS = "FVALUE_DETAILS";

        /// <summary>
        /// Catalog element GENERATOR_INFO
        /// </summary>
        public const string CatElementGENERATOR_INFO = "GENERATOR_INFO";

        /// <summary>
        /// Catalog element GROUP_DESCRIPTION
        /// </summary>
        public const string CatElementGROUP_DESCRIPTION = "GROUP_DESCRIPTION";

        /// <summary>
        /// Catalog element GROUP_ID
        /// </summary>
        public const string CatElementGROUP_ID = "GROUP_ID";

        /// <summary>
        /// Catalog element GROUP_NAME
        /// </summary>
        public const string CatElementGROUP_NAME = "GROUP_NAME";

        /// <summary>
        /// Catalog element GROUP_ORDER
        /// </summary>
        public const string CatElementGROUP_ORDER = "GROUP_ORDER";

        /// <summary>
        /// Catalog element GROUP_PRODUCT_ORDER
        /// </summary>
        public const string CatElementGROUP_PRODUCT_ORDER = "GROUP_PRODUCT_ORDER";

        /// <summary>
        /// Catalog element GROUP_SYSTEM_DESCRIPTION
        /// </summary>
        public const string CatElementGROUP_SYSTEM_DESCRIPTION = "GROUP_SYSTEM_DESCRIPTION";

        /// <summary>
        /// Catalog element GROUP_SYSTEM_ID
        /// </summary>
        public const string CatElementGROUP_SYSTEM_ID = "GROUP_SYSTEM_ID";

        /// <summary>
        /// Catalog element GROUP_SYSTEM_NAME
        /// </summary>
        public const string CatElementGROUP_SYSTEM_NAME = "GROUP_SYSTEM_NAME";

        /// <summary>
        /// Catalog element HEADER
        /// </summary>
        public const string CatElementHEADER = "HEADER";

        /// <summary>
        /// Catalog element KEYWORD
        /// </summary>
        public const string CatElementKEYWORD = "KEYWORD";

        /// <summary>
        /// Catalog element LANGUAGE
        /// </summary>
        public const string CatElementLANGUAGE = "LANGUAGE";

        /// <summary>
        /// Catalog element LOWER_BOUND
        /// </summary>
        public const string CatElementLOWER_BOUND = "LOWER_BOUND";

        /// <summary>
        /// Catalog element MANUFACTURER_AID
        /// </summary>
        public const string CatElementMANUFACTURER_AID = "MANUFACTURER_AID";

        /// <summary>
        /// Catalog element MANUFACTURER_NAME
        /// </summary>
        public const string CatElementMANUFACTURER_NAME = "MANUFACTURER_NAME";

        /// <summary>
        /// Catalog element MANUFACTURER_TYPE_DESCR
        /// </summary>
        public const string CatElementMANUFACTURER_TYPE_DESCR = "MANUFACTURER_TYPE_DESCR";

        /// <summary>
        /// Catalog element MIME
        /// </summary>
        public const string CatElementMIME = "MIME";

        /// <summary>
        /// Catalog element MIME_ALT
        /// </summary>
        public const string CatElementMIME_ALT = "MIME_ALT";

        /// <summary>
        /// Catalog element MIME_DESCR
        /// </summary>
        public const string CatElementMIME_DESCR = "MIME_DESCR";

        /// <summary>
        /// Catalog element MIME_INFO
        /// </summary>
        public const string CatElementMIME_INFO = "MIME_INFO";

        /// <summary>
        /// Catalog element MIME_ORDER
        /// </summary>
        public const string CatElementMIME_ORDER = "MIME_ORDER";

        /// <summary>
        /// Catalog element MIME_PURPOSE
        /// </summary>
        public const string CatElementMIME_PURPOSE = "MIME_PURPOSE";

        /// <summary>
        /// Catalog element MIME_ROOT
        /// </summary>
        public const string CatElementMIME_ROOT = "MIME_ROOT";

        /// <summary>
        /// Catalog element MIME_SOURCE
        /// </summary>
        public const string CatElementMIME_SOURCE = "MIME_SOURCE";

        /// <summary>
        /// Catalog element MIME_TYPE
        /// </summary>
        public const string CatElementMIME_TYPE = "MIME_TYPE";

        /// <summary>
        /// Catalog element NAME
        /// </summary>
        public const string CatElementNAME = "NAME";

        /// <summary>
        /// Catalog element NAME2
        /// </summary>
        public const string CatElementNAME2 = "NAME2";

        /// <summary>
        /// Catalog element NAME3
        /// </summary>
        public const string CatElementNAME3 = "NAME3";

        /// <summary>
        /// Catalog element NO_CU_PER_OU
        /// </summary>
        public const string CatElementNO_CU_PER_OU = "NO_CU_PER_OU";

        /// <summary>
        /// Catalog element ORDER_UNIT
        /// </summary>
        public const string CatElementORDER_UNIT = "ORDER_UNIT";

        /// <summary>
        /// Catalog element PACKING_UNITS
        /// </summary>
        public const string CatElementPACKING_UNITS = "PACKING_UNITS";

        /// <summary>
        /// Catalog element PARENT_ID
        /// </summary>
        public const string CatElementPARENT_ID = "PARENT_ID";

        /// <summary>
        /// Catalog element PHONE
        /// </summary>
        public const string CatElementPHONE = "PHONE";

        /// <summary>
        /// Catalog element PRICE_AMOUNT
        /// </summary>
        public const string CatElementPRICE_AMOUNT = "PRICE_AMOUNT";

        /// <summary>
        /// Catalog element PRICE_CURRENCY
        /// </summary>
        public const string CatElementPRICE_CURRENCY = "PRICE_CURRENCY";

        /// <summary>
        /// Catalog element PRICE_FACTOR
        /// </summary>
        public const string CatElementPRICE_FACTOR = "PRICE_FACTOR";

        /// <summary>
        /// Catalog element PRICE_FLAG
        /// </summary>
        public const string CatElementPRICE_FLAG = "PRICE_FLAG";

        /// <summary>
        /// Catalog element PRICE_QUANTITY
        /// </summary>
        public const string CatElementPRICE_QUANTITY = "PRICE_QUANTITY";

        /// <summary>
        /// Catalog element PROD_ID
        /// </summary>
        public const string CatElementPROD_ID = "PROD_ID";

        /// <summary>
        /// Catalog element PROD_ID_TO
        /// </summary>
        public const string CatElementPROD_ID_TO = "PROD_ID_TO";

        /// <summary>
        /// Catalog element PUBLIC_KEY
        /// </summary>
        public const string CatElementPUBLIC_KEY = "PUBLIC_KEY";

        /// <summary>
        /// Catalog element QUANTITY_INTERVAL
        /// </summary>
        public const string CatElementQUANTITY_INTERVAL = "QUANTITY_INTERVAL";

        /// <summary>
        /// Catalog element QUANTITY_MAX
        /// </summary>
        public const string CatElementQUANTITY_MAX = "QUANTITY_MAX";

        /// <summary>
        /// Catalog element QUANTITY_MIN
        /// </summary>
        public const string CatElementQUANTITY_MIN = "QUANTITY_MIN";

        /// <summary>
        /// Catalog element REFERENCE_FEATURE_GROUP_ID
        /// </summary>
        public const string CatElementREFERENCE_FEATURE_GROUP_ID = "REFERENCE_FEATURE_GROUP_ID";

        /// <summary>
        /// Catalog element REFERENCE_FEATURE_GROUP_ID2
        /// </summary>
        public const string CatElementREFERENCE_FEATURE_GROUP_ID2 = "REFERENCE_FEATURE_GROUP_ID2";

        /// <summary>
        /// Catalog element REFERENCE_FEATURE_GROUP_NAME
        /// </summary>
        public const string CatElementREFERENCE_FEATURE_GROUP_NAME = "REFERENCE_FEATURE_GROUP_NAME";

        /// <summary>
        /// Catalog element REFERENCE_FEATURE_SYSTEM_NAME
        /// </summary>
        public const string CatElementREFERENCE_FEATURE_SYSTEM_NAME = "REFERENCE_FEATURE_SYSTEM_NAME";

        /// <summary>
        /// Catalog element REMARKS
        /// </summary>
        public const string CatElementREMARKS = "REMARKS";

        /// <summary>
        /// Catalog element SEGMENT
        /// </summary>
        public const string CatElementSEGMENT = "SEGMENT";

        /// <summary>
        /// Catalog element SPECIAL_TREATMENT_CLASS
        /// </summary>
        public const string CatElementSPECIAL_TREATMENT_CLASS = "SPECIAL_TREATMENT_CLASS";

        /// <summary>
        /// Catalog element STATE
        /// </summary>
        public const string CatElementSTATE = "STATE";

        /// <summary>
        /// Catalog element STREET
        /// </summary>
        public const string CatElementSTREET = "STREET";

        /// <summary>
        /// Catalog element SUPPLIER
        /// </summary>
        public const string CatElementSUPPLIER = "SUPPLIER";

        /// <summary>
        /// Catalog element SUPPLIER_AID
        /// </summary>
        public const string CatElementSUPPLIER_AID = "SUPPLIER_AID";

        /// <summary>
        /// Catalog element SUPPLIER_AID_SUPPLEMENT
        /// </summary>
        public const string CatElementSUPPLIER_AID_SUPPLEMENT = "SUPPLIER_AID_SUPPLEMENT";

        /// <summary>
        /// Catalog element SUPPLIER_ALT_AID
        /// </summary>
        public const string CatElementSUPPLIER_ALT_AID = "SUPPLIER_ALT_AID";

        /// <summary>
        /// Catalog element SUPPLIER_ID
        /// </summary>
        public const string CatElementSUPPLIER_ID = "SUPPLIER_ID";

        /// <summary>
        /// Catalog element SUPPLIER_NAME
        /// </summary>
        public const string CatElementSUPPLIER_NAME = "SUPPLIER_NAME";

        /// <summary>
        /// Catalog element SUPPLIER_PID
        /// </summary>
        public const string CatElementSUPPLIER_PID = "SUPPLIER_PID";

        /// <summary>
        /// Catalog element SUPPLIER_PIDREF
        /// </summary>
        public const string CatElementSUPPLIER_PIDREF = "SUPPLIER_PIDREF";

        /// <summary>
        /// Catalog element SYNONYM
        /// </summary>
        public const string CatElementSYNONYM = "SYNONYM";

        /// <summary>
        /// Catalog element TAX
        /// </summary>
        public const string CatElementTAX = "TAX";

        /// <summary>
        /// Catalog element TERRITORY
        /// </summary>
        public const string CatElementTERRITORY = "TERRITORY";

        /// <summary>
        /// Catalog element TIME
        /// </summary>
        public const string CatElementTIME = "TIME";

        /// <summary>
        /// Catalog element TIMEZONE
        /// </summary>
        public const string CatElementTIMEZONE = "TIMEZONE";

        /// <summary>
        /// Catalog element TRANSACTION
        /// </summary>
        public const string CatElementTRANSACTION = "TRANSACTION";

        /// <summary>
        /// Catalog element T_NEW_CATALOG
        /// </summary>
        public const string CatElementT_NEW_CATALOG = "T_NEW_CATALOG";

        /// <summary>
        /// Catalog element T_UPDATE_PRICES
        /// </summary>
        public const string CatElementT_UPDATE_PRICES = "T_UPDATE_PRICES";

        /// <summary>
        /// Catalog element T_UPDATE_PRODUCTS
        /// </summary>
        public const string CatElementT_UPDATE_PRODUCTS = "T_UPDATE_PRODUCTS";

        /// <summary>
        /// Catalog element UDXS
        /// </summary>
        public const string CatElementUDXS = "UDXS";

        /// <summary>
        /// Catalog element UNIT
        /// </summary>
        public const string CatElementUNIT = "UNIT";

        /// <summary>
        /// Catalog element UNITS
        /// </summary>
        public const string CatElementUNITS = "UNITS";

        /// <summary>
        /// Catalog element UNIT_DESCR
        /// </summary>
        public const string CatElementUNIT_DESCR = "UNIT_DESCR";

        /// <summary>
        /// Catalog element UNIT_ID
        /// </summary>
        public const string CatElementUNIT_ID = "UNIT_ID";

        /// <summary>
        /// Catalog element UNIT_NAME
        /// </summary>
        public const string CatElementUNIT_NAME = "UNIT_NAME";

        /// <summary>
        /// Catalog element URL
        /// </summary>
        public const string CatElementURL = "URL";

        /// <summary>
        /// Catalog element USER_DEFINED_EXTENSIONS
        /// </summary>
        public const string CatElementUSER_DEFINED_EXTENSIONS = "USER_DEFINED_EXTENSIONS";

        /// <summary>
        /// Catalog element VARIANT
        /// </summary>
        public const string CatElementVARIANT = "VARIANT";

        /// <summary>
        /// Catalog element VARIANTS
        /// </summary>
        public const string CatElementVARIANTS = "VARIANTS";

        /// <summary>
        /// Catalog element VORDER
        /// </summary>
        public const string CatElementVORDER = "VORDER";

        /// <summary>
        /// Catalog element ZIP
        /// </summary>
        public const string CatElementZIP = "ZIP";

        /// <summary>
        /// Catalog element ZIPBOX
        /// </summary>
        public const string CatElementZIPBOX = "ZIPBOX";

        /// <summary>
        /// Catalog element UNDEFINED
        /// </summary>
        public const string CatElementUNDEFINED = "UNDEFINED";

        /// <summary>
        /// Catalog element XML
        /// </summary>
        public const string CatElementXML = "XML";

        #endregion

        public static readonly string[] gaga = {"aa","bb"};

        public static readonly string[] NodeName =
        {
            CatElementUNDEFINED, // BMEcat ID 0 is not defined
            CatElementXML, // The Name of BMEcat ID 1 is "XML"
            CatElementDOCTYPE, // The Name of BMEcat ID 2 is "DOCTYPE"
            CatElementAddress, // The Name of BMEcat ID 3 is "ADDRESS"
            CatElementAddressRemarks, // The Name of BMEcat ID 4 is "ADDRESS_REMARKS"
            CatElementAgreement, // The Name of BMEcat ID 5 is "AGREEMENT"
            CatElementAgreementID, // The Name of BMEcat ID 6 is "AGREEMENT_ID"
            CatElementAllowedValue, // The Name of BMEcat ID 7 is "ALLOWED_VALUE"
            CatElementAllowedValues, // The Name of BMEcat ID 8 is "ALLOWED_VALUES"
            CatElementALLOWED_VALUE_DESCR, // The Name of BMEcat ID 9 is "ALLOWED_VALUE_DESCR"
            CatElementALLOWED_VAUE_ID, // The Name of BMEcat ID 10 is "ALLOWED_VALUE_ID"
            CatElementALLOWED_VALUE_IDREF, // The Name of BMEcat ID 11 is "ALLOWED_VALUE_IDREF"
            CatElementALLOWED_VALUE_NAME, // The Name of BMEcat ID 12 is "ALLOWED_VALUE_NAME"
            CatElementARTICLE, // The Name of BMEcat ID 13 is "ARTICLE"
            CatElementARTICLE_DETAILS, // The Name of BMEcat ID 14 is "ARTICLE_DETAILS"
            CatElementARTICLE_FEATURES, // The Name of BMEcat ID 15 is "ARTICLE_FEATURES"
            CatElementARTICLE_ORDER, // The Name of BMEcat ID 16 is "ARTICLE_ORDER"
            CatElementARTICLE_ORDER_DETAILS, // The Name of BMEcat ID 17 is "ARTICLE_ORDER_DETAILS"
            CatElementARTICLE_PRICE, // The Name of BMEcat ID 18 is "ARTICLE_PRICE"
            CatElementARTICLE_PRICE_DETAILS, // The Name of BMEcat ID 19 is "ARTICLE_PRICE_DETAILS"
            CatElementARTICLE_REFERENCE, // The Name of BMEcat ID 20 is "ARTICLE_REFERENCE"
            CatElementARTICLE_STATUS, // The Name of BMEcat ID 21 is "ARTICLE_STATUS"
            CatElementARTICLE_TO_CATALOGGROUP_MAP, // The Name of BMEcat ID 22 is "ARTICLE_TO_CATALOGGROUP_MAP"
            CatElementARTICLE_TO_CATALOGGROUP_MAP_ORDER, // The Name of BMEcat ID 23 is "ARTICLE_TO_CATALOGGROUP_MAP_ORDER"
            CatElementART_ID, // The Name of BMEcat ID 24 is "ART_ID"
            CatElementART_ID_TO, // The Name of BMEcat ID 25 is "ART_ID_TO"
            CatElementBMECAT, // The Name of BMEcat ID 26 is "BMECAT"
            CatElementBMECAT_DATA, // The Name of BMEcat ID 27 is "BMECAT_DATA"
            CatElementBMECAT_FILE, // The Name of BMEcat ID 28 is "BMECAT_FILE"
            CatElementBOXNO, // The Name of BMEcat ID 29 is "BOXNO"
            CatElementBUYER, // The Name of BMEcat ID 30 is "BUYER"
            CatElementBUYER_AID, // The Name of BMEcat ID 31 is "BUYER_AID"
            CatElementBUYER_ID, // The Name of BMEcat ID 32 is "BUYER_ID"
            CatElementBUYER_NAME, // The Name of BMEcat ID 33 is "BUYER_ID"
            CatElementCATALOG, // The Name of BMEcat ID 34 is "CATALOG"
            CatElementCATALOG_GROUP_ID, // The Name of BMEcat ID 35 is "CATALOG_GROUP_ID"
            CatElementCATALOG_GROUP_SYSTEM, // The Name of BMEcat ID 36 is "CATALOG_GROUP_SYSTEM"
            CatElementCATALOG_ID, // The Name of BMEcat ID 37 is "CATALOG_ID"
            CatElementCATALOG_NAME, // The Name of BMEcat ID 38 is "CATALOG_NAME"
            CatElementCATALOG_STRUCTURE, // The Name of BMEcat ID 39 is "CATALOG_STRUCTURE"
            CatElementCATALOG_VERSION, // The Name of BMEcat ID 40 is "CATALOG_VERSION"
            CatElementCITY, // The Name of BMEcat ID 41 is "CITY"
            CatElementCLASSIFICATION_GROUP, // The Name of BMEcat ID 42 is "CLASSIFICATION_GROUP"
            CatElementCLASSIFICATION_GROUPS, // The Name of BMEcat ID 43 is "CLASSIFICATION_GROUPS"
            CatElementCLASSIFICATION_GROUP_DESCR, // The Name of BMEcat ID 44 is "CLASSIFICATION_GROUP_DESCR"
            CatElementCLASSIFICATION_GROUP_FEATURE_TEMPLATE, // The Name of BMEcat ID 45 is "CLASSIFICATION_GROUP_FEATURE_TEMPLATE"
            CatElementCLASSIFICATION_GROUP_FEATURE_TEMPLATES, // The Name of BMEcat ID 46 is "CLASSIFICATION_GROUP_FEATURE_TEMPLATES"
            CatElementCLASSIFICATION_GROUP_ID, // The Name of BMEcat ID 47 is "CLASSIFICATION_GROUP_ID"
            CatElementCLASSIFICATION_GROUP_NAME, // The Name of BMEcat ID 48 is "CLASSIFICATION_GROUP_NAME"
            CatElementCLASSIFICATION_GROUP_PARENT_ID, // The Name of BMEcat ID 49 is "CLASSIFICATION_GROUP_PARENT_ID"
            CatElementCLASSIFICATION_GROUP_SYNONYMS, // The Name of BMEcat ID 50 is "CLASSIFICATION_GROUP_SYNONYMS"
            CatElementCLASSIFICATION_SYSTEM, // The Name of BMEcat ID 51 is "CLASSIFICATION_SYSTEM"
            CatElementCLASSIFICATION_SYSTEM_DESCR, // The Name of BMEcat ID 52 is "CLASSIFICATION_SYSTEM_DESCR"
            CatElementCLASSIFICATION_SYSTEM_FEATURE_TEMPLATE, // The Name of BMEcat ID 53 is "CLASSIFICATION_SYSTEM_FEATURE_TEMPLATE"
            CatElementCLASSIFICATION_SYSTEM_FEATURE_TEMPLATES, // The Name of BMEcat ID 54 is "CLASSIFICATION_SYSTEM_FEATURE_TEMPLATES"
            CatElementCLASSIFICATION_SYSTEM_FULLNAME, // The Name of BMEcat ID 55 is "CLASSIFICATION_SYSTEM_FULLNAME"
            CatElementCLASSIFICATION_SYSTEM_LEVELS, // The Name of BMEcat ID 56 is "CLASSIFICATION_SYSTEM_LEVELS"
            CatElementCLASSIFICATION_SYSTEM_LEVEL_NAME, // The Name of BMEcat ID 57 is "CLASSIFICATION_SYSTEM_LEVEL_NAME"
            CatElementCLASSIFICATION_SYSTEM_LEVEL_NAMES, // The Name of BMEcat ID 58 is "CLASSIFICATION_SYSTEM_LEVEL_NAMES"
            CatElementCLASSIFICATION_SYSTEM_NAME, // The Name of BMEcat ID 59 is "CLASSIFICATION_SYSTEM_NAME"
            CatElementCLASSIFICATION_SYSTEM_VERSION, // The Name of BMEcat ID 60 is "CLASSIFICATION_SYSTEM_VERSION"
            CatElementCONTACT, // The Name of BMEcat ID 61 is "CONTACT"
            CatElementCONTENT_UNIT, // The Name of BMEcat ID 62 is "CONTENT_UNIT"
            CatElementCOUNTRY, // The Name of BMEcat ID 63 is "COUNTRY"
            CatElementCURRENCY, // The Name of BMEcat ID 64 is "CURRENCY"
            CatElementDAILY_PRICE, // The Name of BMEcat ID 65 is "DAILY_PRICE"
            CatElementDATE, // The Name of BMEcat ID 66 is "DATE"
            CatElementDATETIME, // The Name of BMEcat ID 67 is "DATETIME"
            CatElementDELIVERY_TIME, // The Name of BMEcat ID 68 is "DELIVERY_TIME"
            CatElementDESCRIPTION_LONG, // The Name of BMEcat ID 69 is "DESCRIPTION_LONG"
            CatElementDESCRIPTION_SHORT, // The Name of BMEcat ID 70 is "DESCRIPTION_SHORT"
            CatElementEAN, // The Name of BMEcat ID 71 is "EAN"
            CatElementEMAIL, // The Name of BMEcat ID 72 is "EMAIL"
            CatElementERP_GROUP_BUYER, // The Name of BMEcat ID 73 is "ERP_GROUP_BUYER"
            CatElementERP_GROUP_SUPPLIER, // The Name of BMEcat ID 74 is "ERP_GROUP_SUPPLIER"
            CatElementFAX, // The Name of BMEcat ID 75 is "FAX"
            CatElementFDESCR, // The Name of BMEcat ID 76 is "FDESCR"
            CatElementFEATURE, // The Name of BMEcat ID 77 is "FEATURE"
            CatElementFEATURE_GROUP, // The Name of BMEcat ID 78 is "FEATURE_GROUP"
            CatElementFEATURE_GROUP_DESCR, // The Name of BMEcat ID 79 is "FEATURE_GROUP_DESCR"
            CatElementFEATURE_GROUP_ID, // The Name of BMEcat ID 80 is "FEATURE_GROUP_ID"
            CatElementFEATURE_GROUP_NAME, // The Name of BMEcat ID 81 is "FEATURE_GROUP_NAME"
            CatElementFEATURE_SYSTEM, // The Name of BMEcat ID 82 is "FEATURE_SYSTEM"
            CatElementFEATURE_SYSTEM_DESCR, // The Name of BMEcat ID 83 is "FEATURE_SYSTEM_DESCR"
            CatElementFEATURE_SYSTEM_NAME, // The Name of BMEcat ID 84 is "FEATURE_SYSTEM_NAME"
            CatElementFEATURE_TEMPLATE, // The Name of BMEcat ID 85 is "FEATURE_TEMPLATE"
            CatElementFNAME, // The Name of BMEcat ID 86 is "FNAME"
            CatElementFORDER, // The Name of BMEcat ID 87 is "FORDER"
            CatElementFT_ALLOWED_VALUES, // The Name of BMEcat ID 88 is "FT_ALLOWED_VALUES"
            CatElementFT_DATATYPE, // The Name of BMEcat ID 89 is "FT_DATATYPE"
            CatElementFT_DESCR, // The Name of BMEcat ID 90 is "FT_DESCR"
            CatElementFT_ID, // The Name of BMEcat ID 91 is "FT_ID"
            CatElementFT_IDREF, // The Name of BMEcat ID 92 is "FT_IDREF"
            CatElementFT_MANDATORY, // The Name of BMEcat ID 93 is "FT_MANDATORY"
            CatElementFT_NAME, // The Name of BMEcat ID 94 is "FT_NAME"
            CatElementFT_ORDER, // The Name of BMEcat ID 95 is "FT_ORDER"
            CatElementFT_UNIT, // The Name of BMEcat ID 96 is "FT_UNIT"
            CatElementFUNIT, // The Name of BMEcat ID 97 is "FUNIT"
            CatElementFVALUE, // The Name of BMEcat ID 98 is "FVALUE"
            CatElementFVALUE_DETAILS, // The Name of BMEcat ID 99 is "FVALUE_DETAILS"
            CatElementGENERATOR_INFO, // The Name of BMEcat ID 100 is "GENERATOR_INFO"
            CatElementGROUP_DESCRIPTION, // The Name of BMEcat ID 101 is "GROUP_DESCRIPTION"
            CatElementGROUP_ID, // The Name of BMEcat ID 102 is "GROUP_ID"
            CatElementGROUP_NAME, // The Name of BMEcat ID 103 is "GROUP_NAME"
            CatElementGROUP_ORDER, // The Name of BMEcat ID 104 is "GROUP_ORDER"
            CatElementGROUP_PRODUCT_ORDER, // The Name of BMEcat ID 105 is "GROUP_PRODUCT_ORDER"
            CatElementGROUP_SYSTEM_DESCRIPTION, // The Name of BMEcat ID 106 is "GROUP_SYSTEM_DESCRIPTION"
            CatElementGROUP_SYSTEM_ID, // The Name of BMEcat ID 107 is "GROUP_SYSTEM_ID"
            CatElementGROUP_SYSTEM_NAME, // The Name of BMEcat ID 108 is "GROUP_SYSTEM_NAME"
            CatElementHEADER, // The Name of BMEcat ID 109 is "HEADER"
            CatElementKEYWORD, // The Name of BMEcat ID 110 is "KEYWORD"
            CatElementLANGUAGE, // The Name of BMEcat ID 111 is "LANGUAGE"
            CatElementLOWER_BOUND, // The Name of BMEcat ID 112 is "LOWER_BOUND"
            CatElementMANUFACTURER_AID, // The Name of BMEcat ID 113 is "MANUFACTURER_AID"
            CatElementMANUFACTURER_NAME, // The Name of BMEcat ID 114 is "MANUFACTURER_NAME"
            CatElementMANUFACTURER_TYPE_DESCR, // The Name of BMEcat ID 115 is "MANUFACTURER_TYPE_DESCR"
            CatElementMIME, // The Name of BMEcat ID 116 is "MIME"
            CatElementMIME_ALT, // The Name of BMEcat ID 117 is "MIME_ALT"
            CatElementMIME_DESCR, // The Name of BMEcat ID 118 is "MIME_DESCR"
            CatElementMIME_INFO, // The Name of BMEcat ID 119 is "MIME_INFO"
            CatElementMIME_ORDER, // The Name of BMEcat ID 120 is "MIME_ORDER"
            CatElementMIME_PURPOSE, // The Name of BMEcat ID 121 is "MIME_PURPOSE"
            CatElementMIME_ROOT, // The Name of BMEcat ID 122 is "MIME_ROOT"
            CatElementMIME_SOURCE, // The Name of BMEcat ID 123 is "MIME_SOURCE"
            CatElementMIME_TYPE, // The Name of BMEcat ID 124 is "MIME_TYPE"
            CatElementNAME, // The Name of BMEcat ID 125 is "NAME"
            CatElementNAME2, // The Name of BMEcat ID 126 is "NAME2"
            CatElementNAME3, // The Name of BMEcat ID 127 is "NAME3"
            CatElementNO_CU_PER_OU, // The Name of BMEcat ID 128 is "NO_CU_PER_OU"
            CatElementORDER_UNIT, // The Name of BMEcat ID 129 is "ORDER_UNIT"
            CatElementPACKING_UNITS, // The Name of BMEcat ID 130 is "PACKING_UNITS"
            CatElementPARENT_ID, // The Name of BMEcat ID 131 is "PARENT_ID"
            CatElementPHONE, // The Name of BMEcat ID 132 is "PHONE"
            CatElementPRICE_AMOUNT, // The Name of BMEcat ID 133 is "PRICE_AMOUNT"
            CatElementPRICE_CURRENCY, // The Name of BMEcat ID 134 is "PRICE_CURRENCY"
            CatElementPRICE_FACTOR, // The Name of BMEcat ID 135 is "PRICE_FACTOR"
            CatElementPRICE_FLAG, // The Name of BMEcat ID 136 is "PRICE_FLAG"
            CatElementPRICE_QUANTITY, // The Name of BMEcat ID 137 is "PRICE_QUANTITY"
            CatElementPROD_ID, // The Name of BMEcat ID 138 is "PROD_ID"
            CatElementPROD_ID_TO, // The Name of BMEcat ID 139 is "PROD_ID_TO"
            CatElementPUBLIC_KEY, // The Name of BMEcat ID 140 is "PUBLIC_KEY"
            CatElementQUANTITY_INTERVAL, // The Name of BMEcat ID 141 is "QUANTITY_INTERVAL"
            CatElementQUANTITY_MAX, // The Name of BMEcat ID 142 is "QUANTITY_MAX"
            CatElementQUANTITY_MIN, // The Name of BMEcat ID 143 is "QUANTITY_MIN"
            CatElementREFERENCE_FEATURE_GROUP_ID, // The Name of BMEcat ID 144 is "REFERENCE_FEATURE_GROUP_ID"
            CatElementREFERENCE_FEATURE_GROUP_ID2, // The Name of BMEcat ID 145 is "REFERENCE_FEATURE_GROUP_ID2"
            CatElementREFERENCE_FEATURE_GROUP_NAME, // The Name of BMEcat ID 146 is "REFERENCE_FEATURE_GROUP_NAME"
            CatElementREFERENCE_FEATURE_SYSTEM_NAME, // The Name of BMEcat ID 147 is "REFERENCE_FEATURE_SYSTEM_NAME"
            CatElementREMARKS, // The Name of BMEcat ID 148 is "REMARKS"
            CatElementSEGMENT, // The Name of BMEcat ID 149 is "SEGMENT"
            CatElementSPECIAL_TREATMENT_CLASS, // The Name of BMEcat ID 150 is "SPECIAL_TREATMENT_CLASS"
            CatElementSTATE, // The Name of BMEcat ID 151 is "STATE"
            CatElementSTREET, // The Name of BMEcat ID 152 is "STREET"
            CatElementSUPPLIER, // The Name of BMEcat ID 153 is "SUPPLIER"
            CatElementSUPPLIER_AID, // The Name of BMEcat ID 154 is "SUPPLIER_AID"
            CatElementSUPPLIER_AID_SUPPLEMENT, // The Name of BMEcat ID 155 is "SUPPLIER_AID_SUPPLEMENT"
            CatElementSUPPLIER_ALT_AID, // The Name of BMEcat ID 156 is "SUPPLIER_ALT_AID"
            CatElementSUPPLIER_ID, // The Name of BMEcat ID 157 is "SUPPLIER_ID"
            CatElementSUPPLIER_NAME, // The Name of BMEcat ID 158 is "SUPPLIER_NAME"
            CatElementSUPPLIER_PID, // The Name of BMEcat ID 159 is "SUPPLIER_PID"
            CatElementSUPPLIER_PIDREF, // The Name of BMEcat ID 160 is "SUPPLIER_PIDREF"
            CatElementSYNONYM, // The Name of BMEcat ID 161 is "SYNONYM"
            CatElementTAX, // The Name of BMEcat ID 162 is "TAX"
            CatElementTERRITORY, // The Name of BMEcat ID 163 is "TERRITORY"
            CatElementTIME, // The Name of BMEcat ID 164 is "TIME"
            CatElementTIMEZONE, // The Name of BMEcat ID 165 is "TIMEZONE"
            CatElementTRANSACTION, // The Name of BMEcat ID 166 is "TRANSACTION"
            CatElementT_NEW_CATALOG, // The Name of BMEcat ID 167 is "T_NEW_CATALOG"
            CatElementT_UPDATE_PRICES, // The Name of BMEcat ID 168 is "T_UPDATE_PRICES"
            CatElementT_UPDATE_PRODUCTS, // The Name of BMEcat ID 169 is "T_UPDATE_PRODUCTS"
            CatElementUDXS, // The Name of BMEcat ID 170 is "UDXS"
            CatElementUNIT, // The Name of BMEcat ID 171 is "UNIT"
            CatElementUNITS, // The Name of BMEcat ID 172 is "UNITS"
            CatElementUNIT_DESCR, // The Name of BMEcat ID 173 is "UNIT_DESCR"
            CatElementUNIT_ID, // The Name of BMEcat ID 174 is "UNIT_ID"
            CatElementUNIT_NAME, // The Name of BMEcat ID 175 is "UNIT_NAME"
            CatElementURL, // The Name of BMEcat ID 176 is "URL"
            CatElementUSER_DEFINED_EXTENSIONS, // The Name of BMEcat ID 177 is "USER_DEFINED_EXTENSIONS"
            CatElementVARIANT, // The Name of BMEcat ID 178 is "VARIANT"
            CatElementVARIANTS, // The Name of BMEcat ID 179 is "VARIANTS"
            CatElementVORDER, // The Name of BMEcat ID 180 is "VORDER"
            CatElementZIP, // The Name of BMEcat ID 181 is "ZIP"
            CatElementZIPBOX // The Name of BMEcat ID 182 is "ZIPBOX"
        };

    }
}
