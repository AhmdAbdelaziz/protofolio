import{a as t,b as o,d as V,e as i,f}from"./chunk-K3EI6ARL.js";var b=class{};t(b,"cartColumns"),b.columnsKey="onlinestore.cart";var A=o(i(),1);var u=class{};t(u,"cartRow"),u.idProperty="Id",u.nameProperty="UserId",u.localTextPrefix="onlinestore.cart",u.deletePermission="cart",u.insertPermission="cart",u.readPermission="cart",u.updatePermission="cart",u.Fields=(0,A.fieldsProxy)();var B=o(i(),1),z;(e=>(e.baseUrl="onlinestore/cart",e.Methods={Create:"onlinestore/cart/Create",Update:"onlinestore/cart/Update",Delete:"onlinestore/cart/Delete",Retrieve:"onlinestore/cart/Retrieve",List:"onlinestore/cart/List"},["Create","Update","Delete","Retrieve","List"].forEach(r=>{e[r]=function(a,c,d){return(0,B.serviceRequest)(e.baseUrl+"/"+r,a,c,d)}})))(z||(z={}));var O=class{};t(O,"categoryColumns"),O.columnsKey="onlinestore.category";var x=o(i(),1);var l=class{static getLookup(){return(0,x.getLookup)("onlinestore.category")}static getLookupAsync(){return V(this,null,function*(){return(0,x.getLookupAsync)("onlinestore.category")})}};t(l,"categoryRow"),l.idProperty="Id",l.nameProperty="Name",l.localTextPrefix="onlinestore.category",l.lookupKey="onlinestore.category",l.deletePermission="category",l.insertPermission="category",l.readPermission="category",l.updatePermission="category",l.Fields=(0,x.fieldsProxy)();var G=o(i(),1),F;(e=>(e.baseUrl="onlinestore/category",e.Methods={Create:"onlinestore/category/Create",Update:"onlinestore/category/Update",Delete:"onlinestore/category/Delete",Retrieve:"onlinestore/category/Retrieve",List:"onlinestore/category/List"},["Create","Update","Delete","Retrieve","List"].forEach(r=>{e[r]=function(a,c,d){return(0,G.serviceRequest)(e.baseUrl+"/"+r,a,c,d)}})))(F||(F={}));var Q=class{};t(Q,"diagramColumns"),Q.columnsKey="onlinestore.diagram";var W=o(i(),1);var R=class{};t(R,"diagramRow"),R.idProperty="DiagramId",R.nameProperty="Name",R.localTextPrefix="onlinestore.diagram",R.deletePermission="diagram",R.insertPermission="diagram",R.readPermission="diagram",R.updatePermission="diagram",R.Fields=(0,W.fieldsProxy)();var Z=o(i(),1),Y;(e=>(e.baseUrl="onlinestore/diagram",e.Methods={Create:"onlinestore/diagram/Create",Update:"onlinestore/diagram/Update",Delete:"onlinestore/diagram/Delete",Retrieve:"onlinestore/diagram/Retrieve",List:"onlinestore/diagram/List"},["Create","Update","Delete","Retrieve","List"].forEach(r=>{e[r]=function(a,c,d){return(0,Z.serviceRequest)(e.baseUrl+"/"+r,a,c,d)}})))(Y||(Y={}));var H=class{};t(H,"productimageColumns"),H.columnsKey="onlinestore.productimage";var $=o(i(),1);var y=class{};t(y,"productimageRow"),y.idProperty="Id",y.nameProperty="Image",y.localTextPrefix="onlinestore.productimage",y.deletePermission="productimage",y.insertPermission="productimage",y.readPermission="productimage",y.updatePermission="productimage",y.Fields=(0,$.fieldsProxy)();var w=o(i(),1),_;(e=>(e.baseUrl="onlinestore/productimage",e.Methods={Create:"onlinestore/productimage/Create",Update:"onlinestore/productimage/Update",Delete:"onlinestore/productimage/Delete",Retrieve:"onlinestore/productimage/Retrieve",List:"onlinestore/productimage/List"},["Create","Update","Delete","Retrieve","List"].forEach(r=>{e[r]=function(a,c,d){return(0,w.serviceRequest)(e.baseUrl+"/"+r,a,c,d)}})))(_||(_={}));var J=class{};t(J,"productsColumns"),J.columnsKey="onlinestore.products";var ee=o(i(),1);var m=class{};t(m,"productsRow"),m.idProperty="Id",m.nameProperty="Name",m.localTextPrefix="onlinestore.products",m.deletePermission="products",m.insertPermission="products",m.readPermission="products",m.updatePermission="products",m.Fields=(0,ee.fieldsProxy)();var re=o(i(),1),te;(e=>(e.baseUrl="onlinestore/products",e.Methods={Create:"onlinestore/products/Create",Update:"onlinestore/products/Update",Delete:"onlinestore/products/Delete",Retrieve:"onlinestore/products/Retrieve",List:"onlinestore/products/List"},["Create","Update","Delete","Retrieve","List"].forEach(r=>{e[r]=function(a,c,d){return(0,re.serviceRequest)(e.baseUrl+"/"+r,a,c,d)}})))(te||(te={}));var X=class{};t(X,"reviewColumns"),X.columnsKey="onlinestore.review";var oe=o(i(),1);var v=class{};t(v,"reviewRow"),v.idProperty="Id",v.nameProperty="Name",v.localTextPrefix="onlinestore.review",v.deletePermission="review",v.insertPermission="review",v.readPermission="review",v.updatePermission="review",v.Fields=(0,oe.fieldsProxy)();var ie=o(i(),1),se;(e=>(e.baseUrl="onlinestore/review",e.Methods={Create:"onlinestore/review/Create",Update:"onlinestore/review/Update",Delete:"onlinestore/review/Delete",Retrieve:"onlinestore/review/Retrieve",List:"onlinestore/review/List"},["Create","Update","Delete","Retrieve","List"].forEach(r=>{e[r]=function(a,c,d){return(0,ie.serviceRequest)(e.baseUrl+"/"+r,a,c,d)}})))(se||(se={}));var S=o(f(),1),ne=o(i(),1);var P=class extends S.PrefixedContext{constructor(n){if(super(n),!P.init){P.init=!0;var e=S.StringEditor,r=S.IntegerEditor;(0,ne.initFormType)(P,["UserId",e,"ProductId",r,"Qty",r])}}},N=P;t(N,"cartForm"),N.formKey="onlinestore.cart";var h=o(f(),1),ae=o(i(),1);var D=class extends h.PrefixedContext{constructor(n){if(super(n),!D.init){D.init=!0;var e=h.StringEditor;(0,ae.initFormType)(D,["Name",e,"Photo",e,"Description",e])}}},C=D;t(C,"categoryForm"),C.formKey="onlinestore.category";var q=o(f(),1),pe=o(i(),1);var L=class extends q.PrefixedContext{constructor(n){if(super(n),!L.init){L.init=!0;var e=q.StringEditor,r=q.IntegerEditor;(0,pe.initFormType)(L,["Name",e,"PrincipalId",r,"Version",r,"Definition",e])}}},K=L;t(K,"diagramForm"),K.formKey="onlinestore.diagram";var g=o(f(),1),ce=o(i(),1);var E=class extends g.PrefixedContext{constructor(n){if(super(n),!E.init){E.init=!0;var e=g.IntegerEditor,r=g.StringEditor;(0,ce.initFormType)(E,["ProductId",e,"Image",r])}}},T=E;t(T,"productimageForm"),T.formKey="onlinestore.productimage";var p=o(f(),1),de=o(i(),1);var I=class extends p.PrefixedContext{constructor(n){if(super(n),!I.init){I.init=!0;var e=p.StringEditor,r=p.DecimalEditor,a=p.IntegerEditor,c=p.LookupEditor,d=p.ImageUploadEditor,ue=p.DateEditor;(0,de.initFormType)(I,["Name",e,"Price",r,"Description",e,"Code",a,"CategoryId",c,"Photo",d,"SupplierName",e,"EntryDate",ue,"ReviewUrl",e,"Quantity",a])}}},k=I;t(k,"productsForm"),k.formKey="onlinestore.products";var j=o(f(),1),le=o(i(),1);var U=class extends j.PrefixedContext{constructor(n){if(super(n),!U.init){U.init=!0;var e=j.StringEditor;(0,le.initFormType)(U,["Name",e,"Description",e,"Subject",e,"Email",e])}}},M=U;t(M,"reviewForm"),M.formKey="onlinestore.review";export{b as a,N as b,u as c,z as d,O as e,C as f,l as g,F as h,Q as i,K as j,R as k,Y as l,H as m,T as n,y as o,_ as p,J as q,k as r,m as s,te as t,X as u,M as v,v as w,se as x};
//# sourceMappingURL=chunk-TLV4ISTF.js.map