import{i as g,j as p,k as i,l as n}from"../../../_chunks/chunk-TLV4ISTF.js";import{a as t,b as a,c as o,e as f,f as d}from"../../../_chunks/chunk-K3EI6ARL.js";var u=a(f(),1);var s=a(d(),1);var m=a(d(),1);var e=class extends m.EntityDialog{constructor(){super(...arguments);this.form=new p(this.idPrefix)}getFormKey(){return p.formKey}getRowDefinition(){return i}getService(){return n.baseUrl}};t(e,"diagramDialog"),e=o([m.Decorators.registerClass("AdminArea.onlinestore.diagramDialog")],e);var r=class extends s.EntityGrid{getColumnsKey(){return g.columnsKey}getDialogType(){return e}getRowDefinition(){return i}getService(){return n.baseUrl}constructor(c){super(c)}};t(r,"diagramGrid"),r=o([s.Decorators.registerClass("AdminArea.onlinestore.diagramGrid")],r);function y(){(0,u.initFullHeightGridPage)(new r($("#GridDiv")).element)}t(y,"pageInit");export{y as default};
//# sourceMappingURL=diagramPage.js.map