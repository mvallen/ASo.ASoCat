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
        public const string CatElementAllowedValueDescr = "ALLOWED_VALUE_DESCR";

        /// <summary>
        /// Catalog element ALLOWED_VALUE_ID
        /// </summary>
        public const string CatElementAllowedVaueId = "ALLOWED_VALUE_ID";

        /// <summary>
        /// Catalog element ALLOWED_VALUE_IDREF
        /// </summary>
        public const string CatElementAllowedValueIdref = "ALLOWED_VALUE_IDREF";

        /// <summary>
        /// Catalog element ALLOWED_VALUE_NAME
        /// </summary>
        public const string CatElementAllowedValueName = "ALLOWED_VALUE_NAME";

        /// <summary>
        /// Catalog element ARTICLE
        /// </summary>
        public const string CatElementArticle = "ARTICLE";

        /// <summary>
        /// Catalog element ARTICLE_DETAILS
        /// </summary>
        public const string CatElementArticleDetails = "ARTICLE_DETAILS";

        /// <summary>
        /// Catalog element ARTICLE_FEATURES
        /// </summary>
        public const string CatElementArticleFeatures = "ARTICLE_FEATURES";

        /// <summary>
        /// Catalog element ARTICLE_ORDER
        /// </summary>
        public const string CatElementArticleOrder = "ARTICLE_ORDER";


        /// <summary>
        /// Catalog element ARTICLE_ORDER_DETAILS
        /// </summary>
        public const string CatElementArticleOrderDetails = "ARTICLE_ORDER_DETAILS";

        /// <summary>
        /// Catalog element ARTICLE_PRICE
        /// </summary>
        public const string CatElementArticlePrice = "ARTICLE_PRICE";

        /// <summary>
        /// Catalog element ARTICLE_PRICE_DETAILS
        /// </summary>
        public const string CatElementArticlePriceDetails = "ARTICLE_PRICE";

        /// <summary>
        /// Catalog element ARTICLE_REFERENCE
        /// </summary>
        public const string CatElementArticleReference = "ARTICLE_REFERENCE";

        /// <summary>
        /// Catalog element ARTICLE_STATUS
        /// </summary>
        public const string CatElementArticleStatus = "ARTICLE_STATUS";

        /// <summary>
        /// Catalog element ARTICLE_TO_CATALOGGROUP_MAP
        /// </summary>
        public const string CatElementArticleToCataloggroupMap = "ARTICLE_TO_CATALOGGROUP_MAP";

        /// <summary>
        /// Catalog element ARTICLE_TO_CATALOGGROUP_MAP_ORDER
        /// </summary>
        public const string CatElementArticleToCataloggroupMapOrder = "ARTICLE_TO_CATALOGGROUP_MAP_ORDER";

        /// <summary>
        /// Catalog element ART_ID
        /// </summary>
        public const string CatElementArtId = "ART_ID";

        /// <summary>
        /// Catalog element ART_ID_TO
        /// </summary>
        public const string CatElementArtIdTo = "ART_ID_TO";

        /// <summary>
        /// Catalog element BMECAT
        /// </summary>
        public const string CatElementBmecat = "BMECAT";

        /// <summary>
        /// Catalog element BMECAT_DATA
        /// </summary>
        public const string CatElementBmecatData = "BMECAT_DATA";

        /// <summary>
        /// Catalog element BMECAT_FILE
        /// </summary>
        public const string CatElementBmecatFile = "BMECAT_FILE";

        /// <summary>
        /// Catalog element BOXNO
        /// </summary>
        public const string CatElementBoxno = "BOXNO";

        /// <summary>
        /// Catalog element BUYER
        /// </summary>
        public const string CatElementBuyer = "BUYER";

        /// <summary>
        /// Catalog element BUYER_AID
        /// </summary>
        public const string CatElementBuyerAid = "BUYER_AID";

        /// <summary>
        /// Catalog element BUYER_ID
        /// </summary>
        public const string CatElementBuyerId = "BUYER_ID";

        /// <summary>
        /// Catalog element BUYER_NAME
        /// </summary>
        public const string CatElementBuyerName = "BUYER_NAME";

        /// <summary>
        /// Catalog element CATALOG
        /// </summary>
        public const string CatElementCatalog = "CATALOG";

        /// <summary>
        /// Catalog element CATALOG_GROUP_ID
        /// </summary>
        public const string CatElementCatalogGroupId = "CATALOG_GROUP_ID";

        /// <summary>
        /// Catalog element CATALOG_GROUP_SYSTEM
        /// </summary>
        public const string CatElementCatalogGroupSystem = "CATALOG_GROUP_SYSTEM";

        /// <summary>
        /// Catalog element CATALOG_ID
        /// </summary>
        public const string CatElementCatalogId = "CATALOG_ID";

        /// <summary>
        /// Catalog element CATALOG_NAME
        /// </summary>
        public const string CatElementCatalogName = "CATALOG_NAME";

        /// <summary>
        /// Catalog element CATALOG_STRUCTURE
        /// </summary>
        public const string CatElementCatalogStructure = "CATALOG_STRUCTURE";

        /// <summary>
        /// Catalog element CATALOG_VERSION
        /// </summary>
        public const string CatElementCatalogVersion = "CATALOG_VERSION";

        /// <summary>
        /// Catalog element CITY
        /// </summary>
        public const string CatElementCity = "CITY";

        /// <summary>
        /// Catalog element CLASSIFICATION_GROUP
        /// </summary>
        public const string CatElementClassificationGroup = "CLASSIFICATION_GROUP";

        /// <summary>
        /// Catalog element CLASSIFICATION_GROUPS
        /// </summary>
        public const string CatElementClassificationGroups = "CLASSIFICATION_GROUPS";

        /// <summary>
        /// Catalog element CLASSIFICATION_GROUP_DESCR
        /// </summary>
        public const string CatElementClassificationGroupDescr = "CLASSIFICATION_GROUP_DESCR";

        /// <summary>
        /// Catalog element CLASSIFICATION_GROUP_FEATURE_TEMPLATE
        /// </summary>
        public const string CatElementClassificationGroupFeatureTemplate = "CLASSIFICATION_GROUP_FEATURE_TEMPLATE";

        /// <summary>
        /// Catalog element CLASSIFICATION_GROUP_FEATURE_TEMPLATES
        /// </summary>
        public const string CatElementClassificationGroupFeatureTemplates = "CLASSIFICATION_GROUP_FEATURE_TEMPLATES";

        /// <summary>
        /// Catalog element CLASSIFICATION_GROUP_ID
        /// </summary>
        public const string CatElementClassificationGroupId = "CLASSIFICATION_GROUP_ID";

        /// <summary>
        /// Catalog element CLASSIFICATION_GROUP_NAME
        /// </summary>
        public const string CatElementClassificationGroupName = "CLASSIFICATION_GROUP_NAME";

        /// <summary>
        /// Catalog element CLASSIFICATION_GROUP_PARENT_ID
        /// </summary>
        public const string CatElementClassificationGroupParentId = "CLASSIFICATION_GROUP_PARENT_ID";

        /// <summary>
        /// Catalog element CLASSIFICATION_GROUP_SYNONYMS
        /// </summary>
        public const string CatElementClassificationGroupSynonyms = "CLASSIFICATION_GROUP_SYNONYMS";

        /// <summary>
        /// Catalog element CLASSIFICATION_SYSTEM
        /// </summary>
        public const string CatElementClassificationSystem = "CLASSIFICATION_SYSTEM";

        /// <summary>
        /// Catalog element CLASSIFICATION_SYSTEM_DESCR
        /// </summary>
        public const string CatElementClassificationSystemDescr = "CLASSIFICATION_SYSTEM_DESCR";

        /// <summary>
        /// Catalog element CLASSIFICATION_SYSTEM_FEATURE_TEMPLATE
        /// </summary>
        public const string CatElementClassificationSystemFeatureTemplate = "CLASSIFICATION_SYSTEM_FEATURE_TEMPLATE";

        /// <summary>
        /// Catalog element CLASSIFICATION_SYSTEM_FEATURE_TEMPLATES
        /// </summary>
        public const string CatElementClassificationSystemFeatureTemplates = "CLASSIFICATION_SYSTEM_FEATURE_TEMPLATES";

        /// <summary>
        /// Catalog element CLASSIFICATION_SYSTEM_FULLNAME
        /// </summary>
        public const string CatElementClassificationSystemFullname = "CLASSIFICATION_SYSTEM_FULLNAME";

        /// <summary>
        /// Catalog element CLASSIFICATION_SYSTEM_LEVELS
        /// </summary>
        public const string CatElementClassificationSystemLevels = "CLASSIFICATION_SYSTEM_LEVELS";

        /// <summary>
        /// Catalog element CLASSIFICATION_SYSTEM_LEVEL_NAME
        /// </summary>
        public const string CatElementClassificationSystemLevelName = "CLASSIFICATION_SYSTEM_LEVEL_NAME";

        /// <summary>
        /// Catalog element CLASSIFICATION_SYSTEM_LEVEL_NAMES
        /// </summary>
        public const string CatElementClassificationSystemLevelNames = "CLASSIFICATION_SYSTEM_LEVEL_NAMES";

        /// <summary>
        /// Catalog element CLASSIFICATION_SYSTEM_NAME
        /// </summary>
        public const string CatElementClassificationSystemName = "CLASSIFICATION_SYSTEM_NAME";

        /// <summary>
        /// Catalog element CLASSIFICATION_SYSTEM_VERSION
        /// </summary>
        public const string CatElementClassificationSystemVersion = "CLASSIFICATION_SYSTEM_VERSION";

        /// <summary>
        /// Catalog element CONTACT
        /// </summary>
        public const string CatElementContact = "CONTACT";

        /// <summary>
        /// Catalog element CONTENT_UNIT
        /// </summary>
        public const string CatElementContentUnit = "CONTENT_UNIT";

        /// <summary>
        /// Catalog element COUNTRY
        /// </summary>
        public const string CatElementCountry = "COUNTRY";

        /// <summary>
        /// Catalog element CURRENCY
        /// </summary>
        public const string CatElementCurrency = "CURRENCY";

        /// <summary>
        /// Catalog element DAILY_PRICE
        /// </summary>
        public const string CatElementDailyPrice = "DAILY_PRICE";

        /// <summary>
        /// Catalog element DATE
        /// </summary>
        public const string CatElementDate = "DATE";

        /// <summary>
        /// Catalog element DATETIME
        /// </summary>
        public const string CatElementDatetime = "DATETIME";

        /// <summary>
        /// Catalog element DELIVERY_TIME
        /// </summary>
        public const string CatElementDeliveryTime = "DELIVERY_TIME";

        /// <summary>
        /// Catalog element DESCRIPTION_LONG
        /// </summary>
        public const string CatElementDescriptionLong = "DESCRIPTION_LONG";

        /// <summary>
        /// Catalog element DESCRIPTION_SHORT
        /// </summary>
        public const string CatElementDescriptionShort = "DESCRIPTION_SHORT";

        /// <summary>
        /// Catalog element DOCTYPE
        /// </summary>
        public const string CatElementDoctype = "DOCTYPE";

        /// <summary>
        /// Catalog element EAN
        /// </summary>
        public const string CatElementEan = "EAN";

        /// <summary>
        /// Catalog element EMAIL
        /// </summary>
        public const string CatElementEmail = "EMAIL";

        /// <summary>
        /// Catalog element ERP_GROUP_BUYER
        /// </summary>
        public const string CatElementErpGroupBuyer = "ERP_GROUP_BUYER";

        /// <summary>
        /// Catalog element ERP_GROUP_SUPPLIER
        /// </summary>
        public const string CatElementErpGroupSupplier = "ERP_GROUP_SUPPLIER";

        /// <summary>
        /// Catalog element FAX
        /// </summary>
        public const string CatElementFax = "FAX";

        /// <summary>
        /// Catalog element FDESCR
        /// </summary>
        public const string CatElementFdescr = "FDESCR";

        /// <summary>
        /// Catalog element FEATURE
        /// </summary>
        public const string CatElementFeature = "FEATURE";

        /// <summary>
        /// Catalog element FEATURE_GROUP
        /// </summary>
        public const string CatElementFeatureGroup = "FEATURE_GROUP";

        /// <summary>
        /// Catalog element FEATURE_GROUP_DESCR
        /// </summary>
        public const string CatElementFeatureGroupDescr = "FEATURE_GROUP_DESCR";

        /// <summary>
        /// Catalog element FEATURE_GROUP_ID
        /// </summary>
        public const string CatElementFeatureGroupId = "FEATURE_GROUP_ID";

        /// <summary>
        /// Catalog element FEATURE_GROUP_NAME
        /// </summary>
        public const string CatElementFeatureGroupName = "FEATURE_GROUP_NAME";

        /// <summary>
        /// Catalog element FEATURE_SYSTEM
        /// </summary>
        public const string CatElementFeatureSystem = "FEATURE_SYSTEM";

        /// <summary>
        /// Catalog element FEATURE_SYSTEM_DESCR
        /// </summary>
        public const string CatElementFeatureSystemDescr = "FEATURE_SYSTEM_DESCR";

        /// <summary>
        /// Catalog element FEATURE_SYSTEM_NAME
        /// </summary>
        public const string CatElementFeatureSystemName = "FEATURE_SYSTEM_NAME";

        /// <summary>
        /// Catalog element FEATURE_TEMPLATE
        /// </summary>
        public const string CatElementFeatureTemplate = "FEATURE_TEMPLATE";

        /// <summary>
        /// Catalog element FNAME
        /// </summary>
        public const string CatElementFname = "FNAME";

        /// <summary>
        /// Catalog element FORDER
        /// </summary>
        public const string CatElementForder = "FORDER";

        /// <summary>
        /// Catalog element FT_ALLOWED_VALUES
        /// </summary>
        public const string CatElementFtAllowedValues = "FT_ALLOWED_VALUES";

        /// <summary>
        /// Catalog element FT_DATATYPE
        /// </summary>
        public const string CatElementFtDatatype = "FT_DATATYPE";

        /// <summary>
        /// Catalog element FT_DESCR
        /// </summary>
        public const string CatElementFtDescr = "FT_DESCR";

        /// <summary>
        /// Catalog element FT_ID
        /// </summary>
        public const string CatElementFtId = "FT_ID";

        /// <summary>
        /// Catalog element FT_IDREF
        /// </summary>
        public const string CatElementFtIdref = "FT_IDREF";

        /// <summary>
        /// Catalog element FT_MANDATORY
        /// </summary>
        public const string CatElementFtMandatory = "FT_MANDATORY";

        /// <summary>
        /// Catalog element FT_NAME
        /// </summary>
        public const string CatElementFtName = "FT_NAME";

        /// <summary>
        /// Catalog element FT_ORDER
        /// </summary>
        public const string CatElementFtOrder = "FT_ORDER";

        /// <summary>
        /// Catalog element FT_UNIT
        /// </summary>
        public const string CatElementFtUnit = "FT_UNIT";

        /// <summary>
        /// Catalog element FUNIT
        /// </summary>
        public const string CatElementFunit = "FUNIT";

        /// <summary>
        /// Catalog element FVALUE
        /// </summary>
        public const string CatElementFvalue = "FVALUE";

        /// <summary>
        /// Catalog element FVALUE_DETAILS
        /// </summary>
        public const string CatElementFvalueDetails = "FVALUE_DETAILS";

        /// <summary>
        /// Catalog element GENERATOR_INFO
        /// </summary>
        public const string CatElementGeneratorInfo = "GENERATOR_INFO";

        /// <summary>
        /// Catalog element GROUP_DESCRIPTION
        /// </summary>
        public const string CatElementGroupDescription = "GROUP_DESCRIPTION";

        /// <summary>
        /// Catalog element GROUP_ID
        /// </summary>
        public const string CatElementGroupId = "GROUP_ID";

        /// <summary>
        /// Catalog element GROUP_NAME
        /// </summary>
        public const string CatElementGroupName = "GROUP_NAME";

        /// <summary>
        /// Catalog element GROUP_ORDER
        /// </summary>
        public const string CatElementGroupOrder = "GROUP_ORDER";

        /// <summary>
        /// Catalog element GROUP_PRODUCT_ORDER
        /// </summary>
        public const string CatElementGroupProductOrder = "GROUP_PRODUCT_ORDER";

        /// <summary>
        /// Catalog element GROUP_SYSTEM_DESCRIPTION
        /// </summary>
        public const string CatElementGroupSystemDescription = "GROUP_SYSTEM_DESCRIPTION";

        /// <summary>
        /// Catalog element GROUP_SYSTEM_ID
        /// </summary>
        public const string CatElementGroupSystemId = "GROUP_SYSTEM_ID";

        /// <summary>
        /// Catalog element GROUP_SYSTEM_NAME
        /// </summary>
        public const string CatElementGroupSystemName = "GROUP_SYSTEM_NAME";

        /// <summary>
        /// Catalog element HEADER
        /// </summary>
        public const string CatElementHeader = "HEADER";

        /// <summary>
        /// Catalog element KEYWORD
        /// </summary>
        public const string CatElementKeyword = "KEYWORD";

        /// <summary>
        /// Catalog element LANGUAGE
        /// </summary>
        public const string CatElementLanguage = "LANGUAGE";

        /// <summary>
        /// Catalog element LOWER_BOUND
        /// </summary>
        public const string CatElementLowerBound = "LOWER_BOUND";

        /// <summary>
        /// Catalog element MANUFACTURER_AID
        /// </summary>
        public const string CatElementManufacturerAid = "MANUFACTURER_AID";

        /// <summary>
        /// Catalog element MANUFACTURER_NAME
        /// </summary>
        public const string CatElementManufacturerName = "MANUFACTURER_NAME";

        /// <summary>
        /// Catalog element MANUFACTURER_TYPE_DESCR
        /// </summary>
        public const string CatElementManufacturerTypeDescr = "MANUFACTURER_TYPE_DESCR";

        /// <summary>
        /// Catalog element MIME
        /// </summary>
        public const string CatElementMime = "MIME";

        /// <summary>
        /// Catalog element MIME_ALT
        /// </summary>
        public const string CatElementMimeAlt = "MIME_ALT";

        /// <summary>
        /// Catalog element MIME_DESCR
        /// </summary>
        public const string CatElementMimeDescr = "MIME_DESCR";

        /// <summary>
        /// Catalog element MIME_INFO
        /// </summary>
        public const string CatElementMimeInfo = "MIME_INFO";

        /// <summary>
        /// Catalog element MIME_ORDER
        /// </summary>
        public const string CatElementMimeOrder = "MIME_ORDER";

        /// <summary>
        /// Catalog element MIME_PURPOSE
        /// </summary>
        public const string CatElementMimePurpose = "MIME_PURPOSE";

        /// <summary>
        /// Catalog element MIME_ROOT
        /// </summary>
        public const string CatElementMimeRoot = "MIME_ROOT";

        /// <summary>
        /// Catalog element MIME_SOURCE
        /// </summary>
        public const string CatElementMimeSource = "MIME_SOURCE";

        /// <summary>
        /// Catalog element MIME_TYPE
        /// </summary>
        public const string CatElementMimeType = "MIME_TYPE";

        /// <summary>
        /// Catalog element NAME
        /// </summary>
        public const string CatElementName = "NAME";

        /// <summary>
        /// Catalog element NAME2
        /// </summary>
        public const string CatElementName2 = "NAME2";

        /// <summary>
        /// Catalog element NAME3
        /// </summary>
        public const string CatElementName3 = "NAME3";

        /// <summary>
        /// Catalog element NO_CU_PER_OU
        /// </summary>
        public const string CatElementNoCuPerOu = "NO_CU_PER_OU";

        /// <summary>
        /// Catalog element ORDER_UNIT
        /// </summary>
        public const string CatElementOrderUnit = "ORDER_UNIT";

        /// <summary>
        /// Catalog element PACKING_UNITS
        /// </summary>
        public const string CatElementPackingUnits = "PACKING_UNITS";

        /// <summary>
        /// Catalog element PARENT_ID
        /// </summary>
        public const string CatElementParentId = "PARENT_ID";

        /// <summary>
        /// Catalog element PHONE
        /// </summary>
        public const string CatElementPhone = "PHONE";

        /// <summary>
        /// Catalog element PRICE_AMOUNT
        /// </summary>
        public const string CatElementPriceAmount = "PRICE_AMOUNT";

        /// <summary>
        /// Catalog element PRICE_CURRENCY
        /// </summary>
        public const string CatElementPriceCurrency = "PRICE_CURRENCY";

        /// <summary>
        /// Catalog element PRICE_FACTOR
        /// </summary>
        public const string CatElementPriceFactor = "PRICE_FACTOR";

        /// <summary>
        /// Catalog element PRICE_FLAG
        /// </summary>
        public const string CatElementPriceFlag = "PRICE_FLAG";

        /// <summary>
        /// Catalog element PRICE_QUANTITY
        /// </summary>
        public const string CatElementPriceQuantity = "PRICE_QUANTITY";

        /// <summary>
        /// Catalog element PROD_ID
        /// </summary>
        public const string CatElementProdId = "PROD_ID";

        /// <summary>
        /// Catalog element PROD_ID_TO
        /// </summary>
        public const string CatElementProdIdTo = "PROD_ID_TO";

        /// <summary>
        /// Catalog element PUBLIC_KEY
        /// </summary>
        public const string CatElementPublicKey = "PUBLIC_KEY";

        /// <summary>
        /// Catalog element QUANTITY_INTERVAL
        /// </summary>
        public const string CatElementQuantityInterval = "QUANTITY_INTERVAL";

        /// <summary>
        /// Catalog element QUANTITY_MAX
        /// </summary>
        public const string CatElementQuantityMax = "QUANTITY_MAX";

        /// <summary>
        /// Catalog element QUANTITY_MIN
        /// </summary>
        public const string CatElementQuantityMin = "QUANTITY_MIN";

        /// <summary>
        /// Catalog element REFERENCE_FEATURE_GROUP_ID
        /// </summary>
        public const string CatElementReferenceFeatureGroupId = "REFERENCE_FEATURE_GROUP_ID";

        /// <summary>
        /// Catalog element REFERENCE_FEATURE_GROUP_ID2
        /// </summary>
        public const string CatElementReferenceFeatureGroupId2 = "REFERENCE_FEATURE_GROUP_ID2";

        /// <summary>
        /// Catalog element REFERENCE_FEATURE_GROUP_NAME
        /// </summary>
        public const string CatElementReferenceFeatureGroupName = "REFERENCE_FEATURE_GROUP_NAME";

        /// <summary>
        /// Catalog element REFERENCE_FEATURE_SYSTEM_NAME
        /// </summary>
        public const string CatElementReferenceFeatureSystemName = "REFERENCE_FEATURE_SYSTEM_NAME";

        /// <summary>
        /// Catalog element REMARKS
        /// </summary>
        public const string CatElementRemarks = "REMARKS";

        /// <summary>
        /// Catalog element SEGMENT
        /// </summary>
        public const string CatElementSegment = "SEGMENT";

        /// <summary>
        /// Catalog element SPECIAL_TREATMENT_CLASS
        /// </summary>
        public const string CatElementSpecialTreatmentClass = "SPECIAL_TREATMENT_CLASS";

        /// <summary>
        /// Catalog element STATE
        /// </summary>
        public const string CatElementState = "STATE";

        /// <summary>
        /// Catalog element STREET
        /// </summary>
        public const string CatElementStreet = "STREET";

        /// <summary>
        /// Catalog element SUPPLIER
        /// </summary>
        public const string CatElementSupplier = "SUPPLIER";

        /// <summary>
        /// Catalog element SUPPLIER_AID
        /// </summary>
        public const string CatElementSupplierAid = "SUPPLIER_AID";

        /// <summary>
        /// Catalog element SUPPLIER_AID_SUPPLEMENT
        /// </summary>
        public const string CatElementSupplierAidSupplement = "SUPPLIER_AID_SUPPLEMENT";

        /// <summary>
        /// Catalog element SUPPLIER_ALT_AID
        /// </summary>
        public const string CatElementSupplierAltAid = "SUPPLIER_ALT_AID";

        /// <summary>
        /// Catalog element SUPPLIER_ID
        /// </summary>
        public const string CatElementSupplierId = "SUPPLIER_ID";

        /// <summary>
        /// Catalog element SUPPLIER_NAME
        /// </summary>
        public const string CatElementSupplierName = "SUPPLIER_NAME";

        /// <summary>
        /// Catalog element SUPPLIER_PID
        /// </summary>
        public const string CatElementSupplierPid = "SUPPLIER_PID";

        /// <summary>
        /// Catalog element SUPPLIER_PIDREF
        /// </summary>
        public const string CatElementSupplierPidref = "SUPPLIER_PIDREF";

        /// <summary>
        /// Catalog element SYNONYM
        /// </summary>
        public const string CatElementSynonym = "SYNONYM";

        /// <summary>
        /// Catalog element TAX
        /// </summary>
        public const string CatElementTax = "TAX";

        /// <summary>
        /// Catalog element TERRITORY
        /// </summary>
        public const string CatElementTerritory = "TERRITORY";

        /// <summary>
        /// Catalog element TIME
        /// </summary>
        public const string CatElementTime = "TIME";

        /// <summary>
        /// Catalog element TIMEZONE
        /// </summary>
        public const string CatElementTimezone = "TIMEZONE";

        /// <summary>
        /// Catalog element TRANSACTION
        /// </summary>
        public const string CatElementTransaction = "TRANSACTION";

        /// <summary>
        /// Catalog element T_NEW_CATALOG
        /// </summary>
        public const string CatElementTNewCatalog = "T_NEW_CATALOG";

        /// <summary>
        /// Catalog element T_UPDATE_PRICES
        /// </summary>
        public const string CatElementTUpdatePrices = "T_UPDATE_PRICES";

        /// <summary>
        /// Catalog element T_UPDATE_PRODUCTS
        /// </summary>
        public const string CatElementTUpdateProducts = "T_UPDATE_PRODUCTS";

        /// <summary>
        /// Catalog element UDXS
        /// </summary>
        public const string CatElementUdxs = "UDXS";

        /// <summary>
        /// Catalog element UNIT
        /// </summary>
        public const string CatElementUnit = "UNIT";

        /// <summary>
        /// Catalog element UNITS
        /// </summary>
        public const string CatElementUnits = "UNITS";

        /// <summary>
        /// Catalog element UNIT_DESCR
        /// </summary>
        public const string CatElementUnitDescr = "UNIT_DESCR";

        /// <summary>
        /// Catalog element UNIT_ID
        /// </summary>
        public const string CatElementUnitId = "UNIT_ID";

        /// <summary>
        /// Catalog element UNIT_NAME
        /// </summary>
        public const string CatElementUnitName = "UNIT_NAME";

        /// <summary>
        /// Catalog element URL
        /// </summary>
        public const string CatElementUrl = "URL";

        /// <summary>
        /// Catalog element USER_DEFINED_EXTENSIONS
        /// </summary>
        public const string CatElementUserDefinedExtensions = "USER_DEFINED_EXTENSIONS";

        /// <summary>
        /// Catalog element VARIANT
        /// </summary>
        public const string CatElementVariant = "VARIANT";

        /// <summary>
        /// Catalog element VARIANTS
        /// </summary>
        public const string CatElementVariants = "VARIANTS";

        /// <summary>
        /// Catalog element VORDER
        /// </summary>
        public const string CatElementVorder = "VORDER";

        /// <summary>
        /// Catalog element ZIP
        /// </summary>
        public const string CatElementZip = "ZIP";

        /// <summary>
        /// Catalog element ZIPBOX
        /// </summary>
        public const string CatElementZipbox = "ZIPBOX";

        /// <summary>
        /// Catalog element UNDEFINED
        /// </summary>
        public const string CatElementUndefined = "UNDEFINED";

        /// <summary>
        /// Catalog element XML
        /// </summary>
        public const string CatElementXml = "XML";

        #endregion

        /// <summary>
        /// Sequence of catalog element names.
        /// </summary>
        public static readonly string[] NodeName =
        {
            CatElementUndefined,                            // Catalog ID 0 is not defined
            CatElementXml,                                  // The Name of catalog ID   1 is "XML"
            CatElementDoctype,                              // The Name of catalog ID   2 is "DOCTYPE"
            CatElementAddress,                              // The Name of catalog ID   3 is "ADDRESS"
            CatElementAddressRemarks,                       // The Name of catalog ID   4 is "ADDRESS_REMARKS"
            CatElementAgreement,                            // The Name of catalog ID   5 is "AGREEMENT"
            CatElementAgreementID,                          // The Name of catalog ID   6 is "AGREEMENT_ID"
            CatElementAllowedValue,                         // The Name of catalog ID   7 is "ALLOWED_VALUE"
            CatElementAllowedValues,                        // The Name of catalog ID   8 is "ALLOWED_VALUES"
            CatElementAllowedValueDescr,                    // The Name of catalog ID   9 is "ALLOWED_VALUE_DESCR"
            CatElementAllowedVaueId,                        // The Name of catalog ID  10 is "ALLOWED_VALUE_ID"
            CatElementAllowedValueIdref,                    // The Name of catalog ID  11 is "ALLOWED_VALUE_IDREF"
            CatElementAllowedValueName,                     // The Name of catalog ID  12 is "ALLOWED_VALUE_NAME"
            CatElementArticle,                              // The Name of catalog ID  13 is "ARTICLE"
            CatElementArticleDetails,                       // The Name of catalog ID  14 is "ARTICLE_DETAILS"
            CatElementArticleFeatures,                      // The Name of catalog ID  15 is "ARTICLE_FEATURES"
            CatElementArticleOrder,                         // The Name of catalog ID  16 is "ARTICLE_ORDER"
            CatElementArticleOrderDetails,                  // The Name of catalog ID  17 is "ARTICLE_ORDER_DETAILS"
            CatElementArticlePrice,                         // The Name of catalog ID  18 is "ARTICLE_PRICE"
            CatElementArticlePriceDetails,                  // The Name of catalog ID  19 is "ARTICLE_PRICE_DETAILS"
            CatElementArticleReference,                     // The Name of catalog ID  20 is "ARTICLE_REFERENCE"
            CatElementArticleStatus,                        // The Name of catalog ID  21 is "ARTICLE_STATUS"
            CatElementArticleToCataloggroupMap,             // The Name of catalog ID  22 is "ARTICLE_TO_CATALOGGROUP_MAP"
            CatElementArticleToCataloggroupMapOrder,        // The Name of catalog ID  23 is "ARTICLE_TO_CATALOGGROUP_MAP_ORDER"
            CatElementArtId,                                // The Name of catalog ID  24 is "ART_ID"
            CatElementArtIdTo,                              // The Name of catalog ID  25 is "ART_ID_TO"
            CatElementBmecat,                               // The Name of catalog ID  26 is "BMECAT"
            CatElementBmecatData,                           // The Name of catalog ID  27 is "BMECAT_DATA"
            CatElementBmecatFile,                           // The Name of catalog ID  28 is "BMECAT_FILE"
            CatElementBoxno,                                // The Name of catalog ID  29 is "BOXNO"
            CatElementBuyer,                                // The Name of catalog ID  30 is "BUYER"
            CatElementBuyerAid,                             // The Name of catalog ID  31 is "BUYER_AID"
            CatElementBuyerId,                              // The Name of catalog ID  32 is "BUYER_ID"
            CatElementBuyerName,                            // The Name of catalog ID  33 is "BUYER_ID"
            CatElementCatalog,                              // The Name of catalog ID  34 is "CATALOG"
            CatElementCatalogGroupId,                       // The Name of catalog ID  35 is "CATALOG_GROUP_ID"
            CatElementCatalogGroupSystem,                   // The Name of catalog ID  36 is "CATALOG_GROUP_SYSTEM"
            CatElementCatalogId,                            // The Name of catalog ID  37 is "CATALOG_ID"
            CatElementCatalogName,                          // The Name of catalog ID  38 is "CATALOG_NAME"
            CatElementCatalogStructure,                     // The Name of catalog ID  39 is "CATALOG_STRUCTURE"
            CatElementCatalogVersion,                       // The Name of catalog ID  40 is "CATALOG_VERSION"
            CatElementCity,                                 // The Name of catalog ID  41 is "CITY"
            CatElementClassificationGroup,                  // The Name of catalog ID  42 is "CLASSIFICATION_GROUP"
            CatElementClassificationGroups,                 // The Name of catalog ID  43 is "CLASSIFICATION_GROUPS"
            CatElementClassificationGroupDescr,             // The Name of catalog ID  44 is "CLASSIFICATION_GROUP_DESCR"
            CatElementClassificationGroupFeatureTemplate,   // The Name of catalog ID  45 is "CLASSIFICATION_GROUP_FEATURE_TEMPLATE"
            CatElementClassificationGroupFeatureTemplates,  // The Name of catalog ID  46 is "CLASSIFICATION_GROUP_FEATURE_TEMPLATES"
            CatElementClassificationGroupId,                // The Name of catalog ID  47 is "CLASSIFICATION_GROUP_ID"
            CatElementClassificationGroupName,              // The Name of catalog ID  48 is "CLASSIFICATION_GROUP_NAME"
            CatElementClassificationGroupParentId,          // The Name of catalog ID  49 is "CLASSIFICATION_GROUP_PARENT_ID"
            CatElementClassificationGroupSynonyms,          // The Name of catalog ID  50 is "CLASSIFICATION_GROUP_SYNONYMS"
            CatElementClassificationSystem,                 // The Name of catalog ID  51 is "CLASSIFICATION_SYSTEM"
            CatElementClassificationSystemDescr,            // The Name of catalog ID  52 is "CLASSIFICATION_SYSTEM_DESCR"
            CatElementClassificationSystemFeatureTemplate,  // The Name of catalog ID  53 is "CLASSIFICATION_SYSTEM_FEATURE_TEMPLATE"
            CatElementClassificationSystemFeatureTemplates, // The Name of catalog ID  54 is "CLASSIFICATION_SYSTEM_FEATURE_TEMPLATES"
            CatElementClassificationSystemFullname,         // The Name of catalog ID  55 is "CLASSIFICATION_SYSTEM_FULLNAME"
            CatElementClassificationSystemLevels,           // The Name of catalog ID  56 is "CLASSIFICATION_SYSTEM_LEVELS"
            CatElementClassificationSystemLevelName,        // The Name of catalog ID  57 is "CLASSIFICATION_SYSTEM_LEVEL_NAME"
            CatElementClassificationSystemLevelNames,       // The Name of catalog ID  58 is "CLASSIFICATION_SYSTEM_LEVEL_NAMES"
            CatElementClassificationSystemName,             // The Name of catalog ID  59 is "CLASSIFICATION_SYSTEM_NAME"
            CatElementClassificationSystemVersion,          // The Name of catalog ID  60 is "CLASSIFICATION_SYSTEM_VERSION"
            CatElementContact,                              // The Name of catalog ID  61 is "CONTACT"
            CatElementContentUnit,                          // The Name of catalog ID  62 is "CONTENT_UNIT"
            CatElementCountry,                              // The Name of catalog ID  63 is "COUNTRY"
            CatElementCurrency,                             // The Name of catalog ID  64 is "CURRENCY"
            CatElementDailyPrice,                           // The Name of catalog ID  65 is "DAILY_PRICE"
            CatElementDate,                                 // The Name of catalog ID  66 is "DATE"
            CatElementDatetime,                             // The Name of catalog ID  67 is "DATETIME"
            CatElementDeliveryTime,                         // The Name of catalog ID  68 is "DELIVERY_TIME"
            CatElementDescriptionLong,                      // The Name of catalog ID  69 is "DESCRIPTION_LONG"
            CatElementDescriptionShort,                     // The Name of catalog ID  70 is "DESCRIPTION_SHORT"
            CatElementEan,                                  // The Name of catalog ID  71 is "EAN"
            CatElementEmail,                                // The Name of catalog ID  72 is "EMAIL"
            CatElementErpGroupBuyer,                        // The Name of catalog ID  73 is "ERP_GROUP_BUYER"
            CatElementErpGroupSupplier,                     // The Name of catalog ID  74 is "ERP_GROUP_SUPPLIER"
            CatElementFax,                                  // The Name of catalog ID  75 is "FAX"
            CatElementFdescr,                               // The Name of catalog ID  76 is "FDESCR"
            CatElementFeature,                              // The Name of catalog ID  77 is "FEATURE"
            CatElementFeatureGroup,                         // The Name of catalog ID  78 is "FEATURE_GROUP"
            CatElementFeatureGroupDescr,                    // The Name of catalog ID  79 is "FEATURE_GROUP_DESCR"
            CatElementFeatureGroupId,                       // The Name of catalog ID  80 is "FEATURE_GROUP_ID"
            CatElementFeatureGroupName,                     // The Name of catalog ID  81 is "FEATURE_GROUP_NAME"
            CatElementFeatureSystem,                        // The Name of catalog ID  82 is "FEATURE_SYSTEM"
            CatElementFeatureSystemDescr,                   // The Name of catalog ID  83 is "FEATURE_SYSTEM_DESCR"
            CatElementFeatureSystemName,                    // The Name of catalog ID  84 is "FEATURE_SYSTEM_NAME"
            CatElementFeatureTemplate,                      // The Name of catalog ID  85 is "FEATURE_TEMPLATE"
            CatElementFname,                                // The Name of catalog ID  86 is "FNAME"
            CatElementForder,                               // The Name of catalog ID  87 is "FORDER"
            CatElementFtAllowedValues,                      // The Name of catalog ID  88 is "FT_ALLOWED_VALUES"
            CatElementFtDatatype,                           // The Name of catalog ID  89 is "FT_DATATYPE"
            CatElementFtDescr,                              // The Name of catalog ID  90 is "FT_DESCR"
            CatElementFtId,                                 // The Name of catalog ID  91 is "FT_ID"
            CatElementFtIdref,                              // The Name of catalog ID  92 is "FT_IDREF"
            CatElementFtMandatory,                          // The Name of catalog ID  93 is "FT_MANDATORY"
            CatElementFtName,                               // The Name of catalog ID  94 is "FT_NAME"
            CatElementFtOrder,                              // The Name of catalog ID  95 is "FT_ORDER"
            CatElementFtUnit,                               // The Name of catalog ID  96 is "FT_UNIT"
            CatElementFunit,                                // The Name of catalog ID  97 is "FUNIT"
            CatElementFvalue,                               // The Name of catalog ID  98 is "FVALUE"
            CatElementFvalueDetails,                        // The Name of catalog ID  99 is "FVALUE_DETAILS"
            CatElementGeneratorInfo,                        // The Name of catalog ID 100 is "GENERATOR_INFO"
            CatElementGroupDescription,                     // The Name of catalog ID 101 is "GROUP_DESCRIPTION"
            CatElementGroupId,                              // The Name of catalog ID 102 is "GROUP_ID"
            CatElementGroupName,                            // The Name of catalog ID 103 is "GROUP_NAME"
            CatElementGroupOrder,                           // The Name of catalog ID 104 is "GROUP_ORDER"
            CatElementGroupProductOrder,                    // The Name of catalog ID 105 is "GROUP_PRODUCT_ORDER"
            CatElementGroupSystemDescription,               // The Name of catalog ID 106 is "GROUP_SYSTEM_DESCRIPTION"
            CatElementGroupSystemId,                        // The Name of catalog ID 107 is "GROUP_SYSTEM_ID"
            CatElementGroupSystemName,                      // The Name of catalog ID 108 is "GROUP_SYSTEM_NAME"
            CatElementHeader,                               // The Name of catalog ID 109 is "HEADER"
            CatElementKeyword,                              // The Name of catalog ID 110 is "KEYWORD"
            CatElementLanguage,                             // The Name of catalog ID 111 is "LANGUAGE"
            CatElementLowerBound,                           // The Name of catalog ID 112 is "LOWER_BOUND"
            CatElementManufacturerAid,                      // The Name of catalog ID 113 is "MANUFACTURER_AID"
            CatElementManufacturerName,                     // The Name of catalog ID 114 is "MANUFACTURER_NAME"
            CatElementManufacturerTypeDescr,                // The Name of catalog ID 115 is "MANUFACTURER_TYPE_DESCR"
            CatElementMime,                                 // The Name of catalog ID 116 is "MIME"
            CatElementMimeAlt,                              // The Name of catalog ID 117 is "MIME_ALT"
            CatElementMimeDescr,                            // The Name of catalog ID 118 is "MIME_DESCR"
            CatElementMimeInfo,                             // The Name of catalog ID 119 is "MIME_INFO"
            CatElementMimeOrder,                            // The Name of catalog ID 120 is "MIME_ORDER"
            CatElementMimePurpose,                          // The Name of catalog ID 121 is "MIME_PURPOSE"
            CatElementMimeRoot,                             // The Name of catalog ID 122 is "MIME_ROOT"
            CatElementMimeSource,                           // The Name of catalog ID 123 is "MIME_SOURCE"
            CatElementMimeType,                             // The Name of catalog ID 124 is "MIME_TYPE"
            CatElementName,                                 // The Name of catalog ID 125 is "NAME"
            CatElementName2,                                // The Name of catalog ID 126 is "NAME2"
            CatElementName3,                                // The Name of catalog ID 127 is "NAME3"
            CatElementNoCuPerOu,                            // The Name of catalog ID 128 is "NO_CU_PER_OU"
            CatElementOrderUnit,                            // The Name of catalog ID 129 is "ORDER_UNIT"
            CatElementPackingUnits,                         // The Name of catalog ID 130 is "PACKING_UNITS"
            CatElementParentId,                             // The Name of catalog ID 131 is "PARENT_ID"
            CatElementPhone,                                // The Name of catalog ID 132 is "PHONE"
            CatElementPriceAmount,                          // The Name of catalog ID 133 is "PRICE_AMOUNT"
            CatElementPriceCurrency,                        // The Name of catalog ID 134 is "PRICE_CURRENCY"
            CatElementPriceFactor,                          // The Name of catalog ID 135 is "PRICE_FACTOR"
            CatElementPriceFlag,                            // The Name of catalog ID 136 is "PRICE_FLAG"
            CatElementPriceQuantity,                        // The Name of catalog ID 137 is "PRICE_QUANTITY"
            CatElementProdId,                               // The Name of catalog ID 138 is "PROD_ID"
            CatElementProdIdTo,                             // The Name of catalog ID 139 is "PROD_ID_TO"
            CatElementPublicKey,                            // The Name of catalog ID 140 is "PUBLIC_KEY"
            CatElementQuantityInterval,                     // The Name of catalog ID 141 is "QUANTITY_INTERVAL"
            CatElementQuantityMax,                          // The Name of catalog ID 142 is "QUANTITY_MAX"
            CatElementQuantityMin,                          // The Name of catalog ID 143 is "QUANTITY_MIN"
            CatElementReferenceFeatureGroupId,              // The Name of catalog ID 144 is "REFERENCE_FEATURE_GROUP_ID"
            CatElementReferenceFeatureGroupId2,             // The Name of catalog ID 145 is "REFERENCE_FEATURE_GROUP_ID2"
            CatElementReferenceFeatureGroupName,            // The Name of catalog ID 146 is "REFERENCE_FEATURE_GROUP_NAME"
            CatElementReferenceFeatureSystemName,           // The Name of catalog ID 147 is "REFERENCE_FEATURE_SYSTEM_NAME"
            CatElementRemarks,                              // The Name of catalog ID 148 is "REMARKS"
            CatElementSegment,                              // The Name of catalog ID 149 is "SEGMENT"
            CatElementSpecialTreatmentClass,                // The Name of catalog ID 150 is "SPECIAL_TREATMENT_CLASS"
            CatElementState,                                // The Name of catalog ID 151 is "STATE"
            CatElementStreet,                               // The Name of catalog ID 152 is "STREET"
            CatElementSupplier,                             // The Name of catalog ID 153 is "SUPPLIER"
            CatElementSupplierAid,                          // The Name of catalog ID 154 is "SUPPLIER_AID"
            CatElementSupplierAidSupplement,                // The Name of catalog ID 155 is "SUPPLIER_AID_SUPPLEMENT"
            CatElementSupplierAltAid,                       // The Name of catalog ID 156 is "SUPPLIER_ALT_AID"
            CatElementSupplierId,                           // The Name of catalog ID 157 is "SUPPLIER_ID"
            CatElementSupplierName,                         // The Name of catalog ID 158 is "SUPPLIER_NAME"
            CatElementSupplierPid,                          // The Name of catalog ID 159 is "SUPPLIER_PID"
            CatElementSupplierPidref,                       // The Name of catalog ID 160 is "SUPPLIER_PIDREF"
            CatElementSynonym,                              // The Name of catalog ID 161 is "SYNONYM"
            CatElementTax,                                  // The Name of catalog ID 162 is "TAX"
            CatElementTerritory,                            // The Name of catalog ID 163 is "TERRITORY"
            CatElementTime,                                 // The Name of catalog ID 164 is "TIME"
            CatElementTimezone,                             // The Name of catalog ID 165 is "TIMEZONE"
            CatElementTransaction,                          // The Name of catalog ID 166 is "TRANSACTION"
            CatElementTNewCatalog,                          // The Name of catalog ID 167 is "T_NEW_CATALOG"
            CatElementTUpdatePrices,                        // The Name of catalog ID 168 is "T_UPDATE_PRICES"
            CatElementTUpdateProducts,                      // The Name of catalog ID 169 is "T_UPDATE_PRODUCTS"
            CatElementUdxs,                                 // The Name of catalog ID 170 is "UDXS"
            CatElementUnit,                                 // The Name of catalog ID 171 is "UNIT"
            CatElementUnits,                                // The Name of catalog ID 172 is "UNITS"
            CatElementUnitDescr,                            // The Name of catalog ID 173 is "UNIT_DESCR"
            CatElementUnitId,                               // The Name of catalog ID 174 is "UNIT_ID"
            CatElementUnitName,                             // The Name of catalog ID 175 is "UNIT_NAME"
            CatElementUrl,                                  // The Name of catalog ID 176 is "URL"
            CatElementUserDefinedExtensions,                // The Name of catalog ID 177 is "USER_DEFINED_EXTENSIONS"
            CatElementVariant,                              // The Name of catalog ID 178 is "VARIANT"
            CatElementVariants,                             // The Name of catalog ID 179 is "VARIANTS"
            CatElementVorder,                               // The Name of catalog ID 180 is "VORDER"
            CatElementZip,                                  // The Name of catalog ID 181 is "ZIP"
            CatElementZipbox                                // The Name of catalog ID 182 is "ZIPBOX"
        };


    }
}
