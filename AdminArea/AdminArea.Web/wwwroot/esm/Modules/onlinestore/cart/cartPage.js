import{a as d,b as p,c as i,d as n}from"../../../_chunks/chunk-TLV4ISTF.js";import{a as t,b as s,c as o,e as g,f as u}from"../../../_chunks/chunk-K3EI6ARL.js";var l=s(g(),1);var m=s(u(),1);var c=s(u(),1);var e=class extends c.EntityDialog{constructor(){super(...arguments);this.form=new p(this.idPrefix)}getFormKey(){return p.formKey}getRowDefinition(){return i}getService(){return n.baseUrl}};t(e,"cartDialog"),e=o([c.Decorators.registerClass("AdminArea.onlinestore.cartDialog")],e);var r=class extends m.EntityGrid{getColumnsKey(){return d.columnsKey}getDialogType(){return e}getRowDefinition(){return i}getService(){return n.baseUrl}constructor(a){super(a)}};t(r,"cartGrid"),r=o([m.Decorators.registerClass("AdminArea.onlinestore.cartGrid")],r);function y(){(0,l.initFullHeightGridPage)(new r($("#GridDiv")).element)}t(y,"pageInit");export{y as default};
//# sourceMappingURL=cartPage.js.map