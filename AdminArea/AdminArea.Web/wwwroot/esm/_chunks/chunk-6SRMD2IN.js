import{a as t,b as i,d as x,e as n,f as J}from"./chunk-K3EI6ARL.js";var U=class{};t(U,"LanguageColumns"),U.columnsKey="Administration.Language";var v=i(n(),1);var m=class{static getLookup(){return(0,v.getLookup)("Administration.Language")}static getLookupAsync(){return x(this,null,function*(){return(0,v.getLookupAsync)("Administration.Language")})}};t(m,"LanguageRow"),m.idProperty="Id",m.nameProperty="LanguageName",m.localTextPrefix="Administration.Language",m.lookupKey="Administration.Language",m.deletePermission="Administration:Translation",m.insertPermission="Administration:Translation",m.readPermission="Administration:Translation",m.updatePermission="Administration:Translation",m.Fields=(0,v.fieldsProxy)();var X=i(n(),1),Q;(e=>(e.baseUrl="Administration/Language",e.Methods={Create:"Administration/Language/Create",Update:"Administration/Language/Update",Delete:"Administration/Language/Delete",Retrieve:"Administration/Language/Retrieve",List:"Administration/Language/List"},["Create","Update","Delete","Retrieve","List"].forEach(r=>{e[r]=function(a,p,o){return(0,X.serviceRequest)(e.baseUrl+"/"+r,a,p,o)}})))(Q||(Q={}));var g=class{};t(g,"RoleColumns"),g.columnsKey="Administration.Role";var S=i(n(),1);var u=class{static getLookup(){return(0,S.getLookup)("Administration.Role")}static getLookupAsync(){return x(this,null,function*(){return(0,S.getLookupAsync)("Administration.Role")})}};t(u,"RoleRow"),u.idProperty="RoleId",u.nameProperty="RoleName",u.localTextPrefix="Administration.Role",u.lookupKey="Administration.Role",u.deletePermission="Administration:Security",u.insertPermission="Administration:Security",u.readPermission="Administration:Security",u.updatePermission="Administration:Security",u.Fields=(0,S.fieldsProxy)();var k=i(n(),1),T;(e=>(e.baseUrl="Administration/Role",e.Methods={Create:"Administration/Role/Create",Update:"Administration/Role/Update",Delete:"Administration/Role/Delete",Retrieve:"Administration/Role/Retrieve",List:"Administration/Role/List"},["Create","Update","Delete","Retrieve","List"].forEach(r=>{e[r]=function(a,p,o){return(0,k.serviceRequest)(e.baseUrl+"/"+r,a,p,o)}})))(T||(T={}));var K=i(n(),1),h;(e=>(e.baseUrl="Administration/Translation",e.Methods={List:"Administration/Translation/List",Update:"Administration/Translation/Update"},["List","Update"].forEach(r=>{e[r]=function(a,p,o){return(0,K.serviceRequest)(e.baseUrl+"/"+r,a,p,o)}})))(h||(h={}));var I=class{};t(I,"UserColumns"),I.columnsKey="Administration.User";var A=i(n(),1);var c=class{static getLookup(){return(0,A.getLookup)("Administration.User")}static getLookupAsync(){return x(this,null,function*(){return(0,A.getLookupAsync)("Administration.User")})}};t(c,"UserRow"),c.idProperty="UserId",c.isActiveProperty="IsActive",c.nameProperty="Username",c.localTextPrefix="Administration.User",c.lookupKey="Administration.User",c.deletePermission="Administration:Security",c.insertPermission="Administration:Security",c.readPermission="Administration:Security",c.updatePermission="Administration:Security",c.Fields=(0,A.fieldsProxy)();var C=i(n(),1),N;(e=>(e.baseUrl="Administration/User",e.Methods={Create:"Administration/User/Create",Update:"Administration/User/Update",Delete:"Administration/User/Delete",Retrieve:"Administration/User/Retrieve",List:"Administration/User/List"},["Create","Update","Delete","Retrieve","List"].forEach(r=>{e[r]=function(a,p,o){return(0,C.serviceRequest)(e.baseUrl+"/"+r,a,p,o)}})))(N||(N={}));var b=i(J(),1),M=i(n(),1);var L=class extends b.PrefixedContext{constructor(d){if(super(d),!L.init){L.init=!0;var e=b.StringEditor;(0,M.initFormType)(L,["LanguageId",e,"LanguageName",e])}}},O=L;t(O,"LanguageForm"),O.formKey="Administration.Language";var F;(e=>(e.Security="Administration:Security",e.Translation="Administration:Translation"))(F||(F={}));var E=i(J(),1),G=i(n(),1);var q=class extends E.PrefixedContext{constructor(d){if(super(d),!q.init){q.init=!0;var e=E.StringEditor;(0,G.initFormType)(q,["RoleName",e])}}},D=q;t(D,"RoleForm"),D.formKey="Administration.Role";var j=i(n(),1);var y=class{};t(y,"RolePermissionRow"),y.idProperty="RolePermissionId",y.nameProperty="PermissionKey",y.localTextPrefix="Administration.RolePermission",y.deletePermission="Administration:Security",y.insertPermission="Administration:Security",y.readPermission="Administration:Security",y.updatePermission="Administration:Security",y.Fields=(0,j.fieldsProxy)();var B=i(n(),1),z;(e=>(e.baseUrl="Administration/RolePermission",e.Methods={Update:"Administration/RolePermission/Update",List:"Administration/RolePermission/List"},["Update","List"].forEach(r=>{e[r]=function(a,p,o){return(0,B.serviceRequest)(e.baseUrl+"/"+r,a,p,o)}})))(z||(z={}));var l=i(J(),1),V=i(n(),1);var P=class extends l.PrefixedContext{constructor(d){if(super(d),!P.init){P.init=!0;var e=l.StringEditor,r=l.EmailAddressEditor,a=l.LookupEditor,p=l.ImageUploadEditor,o=l.PasswordEditor;(0,V.initFormType)(P,["Username",e,"DisplayName",e,"Email",r,"Roles",a,"UserImage",p,"Password",o,"PasswordConfirm",o,"Source",e])}}},H=P;t(H,"UserForm"),H.formKey="Administration.User";var W=i(n(),1);var f=class{};t(f,"UserPermissionRow"),f.idProperty="UserPermissionId",f.nameProperty="PermissionKey",f.localTextPrefix="Administration.UserPermission",f.deletePermission="Administration:Security",f.insertPermission="Administration:Security",f.readPermission="Administration:Security",f.updatePermission="Administration:Security",f.Fields=(0,W.fieldsProxy)();var Z=i(n(),1),Y;(e=>(e.baseUrl="Administration/UserPermission",e.Methods={Update:"Administration/UserPermission/Update",List:"Administration/UserPermission/List",ListRolePermissions:"Administration/UserPermission/ListRolePermissions",ListPermissionKeys:"Administration/UserPermission/ListPermissionKeys"},["Update","List","ListRolePermissions","ListPermissionKeys"].forEach(r=>{e[r]=function(a,p,o){return(0,Z.serviceRequest)(e.baseUrl+"/"+r,a,p,o)}})))(Y||(Y={}));var $=i(n(),1);var R=class{};t(R,"UserRoleRow"),R.idProperty="UserRoleId",R.localTextPrefix="Administration.UserRole",R.deletePermission="Administration:Security",R.insertPermission="Administration:Security",R.readPermission="Administration:Security",R.updatePermission="Administration:Security",R.Fields=(0,$.fieldsProxy)();var w=i(n(),1),_;(e=>(e.baseUrl="Administration/UserRole",e.Methods={Update:"Administration/UserRole/Update",List:"Administration/UserRole/List"},["Update","List"].forEach(r=>{e[r]=function(a,p,o){return(0,w.serviceRequest)(e.baseUrl+"/"+r,a,p,o)}})))(_||(_={}));export{U as a,O as b,m as c,Q as d,g as e,D as f,z as g,u as h,T as i,h as j,I as k,H as l,Y as m,c as n,N as o};
//# sourceMappingURL=chunk-6SRMD2IN.js.map
