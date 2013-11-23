/*
*  2007 � 2013 Copyright Northwestern University
*
*  Distributed under the OSI-approved BSD 3-Clause License.
*  See http://ncip.github.com/annotation-and-image-markup/LICENSE.txt for details.

*/

#ifndef _ALTOVA_INCLUDED_AIMXML_ALTOVA__ALTOVA_CReferencedGeometricShape
#define _ALTOVA_INCLUDED_AIMXML_ALTOVA__ALTOVA_CReferencedGeometricShape



namespace AIMXML
{

class CReferencedGeometricShape : public TypeBase
{
public:
	AIMXML_EXPORT CReferencedGeometricShape(xercesc::DOMNode* const& init);
	AIMXML_EXPORT CReferencedGeometricShape(CReferencedGeometricShape const& init);
	void operator=(CReferencedGeometricShape const& other) { m_node = other.m_node; }
	static altova::meta::ComplexType StaticInfo() { return altova::meta::ComplexType(types + _altova_ti_altova_CReferencedGeometricShape); }

	MemberAttribute<__int64,_altova_mi_altova_CReferencedGeometricShape_altova_cagridId, 0, 0> cagridId;	// cagridId Cinteger

	MemberAttribute<__int64,_altova_mi_altova_CReferencedGeometricShape_altova_referencedShapeIdentifier, 0, 0> referencedShapeIdentifier;	// referencedShapeIdentifier Cinteger
	AIMXML_EXPORT void SetXsiType();
};


}	// namespace AIMXML

#endif // _ALTOVA_INCLUDED_AIMXML_ALTOVA__ALTOVA_CReferencedGeometricShape