import{a as p,b as g,c as d,e as v,f as P}from"./chunk-K3EI6ARL.js";var l=g(P(),1),o=g(v(),1);var c=class extends l.DataGrid{constructor(e,t){super(e,t);this._rolePermissions={};this._implicitPermissions={};let s={},n=this.getSortedGroupAndPermissionKeys(s).map(i=>({Key:i,ParentKey:this.getParentKey(i),Title:s[i],GrantRevoke:null,IsGroup:i.charAt(i.length-1)===":"}));this.byParentKey=(0,o.toGrouping)(n,i=>i.ParentKey),this.setItems(n)}getIdProperty(){return"Key"}getItemGrantRevokeClass(e,t){if(!e.IsGroup)return e.GrantRevoke===t?" checked":"";let s=this.getDescendants(e,!0),r=s.filter(n=>n.GrantRevoke===t);return r.length?s.length===r.length?"checked":"checked partial":""}roleOrImplicit(e){if(this._rolePermissions[e])return!0;for(var t of Object.keys(this._rolePermissions)){var s=this._implicitPermissions[t];if(s&&s[e])return!0}for(var r of Object.keys(this._implicitPermissions)){var n=this.view.getItemById(r);if(n&&n.GrantRevoke==!0){var s=this._implicitPermissions[r];if(s&&s[e])return!0}}}getItemEffectiveClass(e){if(e.IsGroup){let s=this.getDescendants(e,!0),r=(0,o.count)(s,n=>n.GrantRevoke===!0||n.GrantRevoke==null&&this.roleOrImplicit(n.Key));return r===s.length||s.length===0?"allow":r===0?"deny":"partial"}return e.GrantRevoke===!0||e.GrantRevoke==null&&this.roleOrImplicit(e.Key)?" allow":" deny"}getColumns(){let e=[{name:(0,o.localText)("Site.UserPermissionDialog.Permission"),field:"Title",format:l.SlickFormatting.treeToggle(()=>this.view,t=>t.Key,t=>{let s=t.item;return'<span class="effective-permission '+this.getItemEffectiveClass(s)+'">'+(0,o.htmlEncode)(t.value)+"</span>"}),width:495,sortable:!1},{name:(0,o.localText)("Site.UserPermissionDialog.Grant"),field:"Grant",format:t=>{let s=t.item;return"<span class='check-box grant no-float "+this.getItemGrantRevokeClass(s,!0)+"'></span>"},width:65,sortable:!1,headerCssClass:"align-center",cssClass:"align-center"}];return this.options.showRevoke&&e.push({name:(0,o.localText)("Site.UserPermissionDialog.Revoke"),field:"Revoke",format:t=>{let s=t.item;return'<span class="check-box revoke no-float '+this.getItemGrantRevokeClass(s,!1)+'"></span>'},width:65,sortable:!1,headerCssClass:"align-center",cssClass:"align-center"}),e}setItems(e){l.SlickTreeHelper.setIndents(e,t=>t.Key,t=>t.ParentKey,!1),this.view.setItems(e,!0)}onViewSubmit(){return!1}onViewFilter(e){return!super.onViewFilter(e)||!l.SlickTreeHelper.filterById(e,this.view,t=>t.ParentKey)?!1:this.searchText?this.matchContains(e)||e.IsGroup&&(0,o.any)(this.getDescendants(e,!1),t=>this.matchContains(t)):!0}matchContains(e){return Select2.util.stripDiacritics(e.Title||"").toLowerCase().indexOf(this.searchText)>=0}getDescendants(e,t){let s=[],r=[e];for(;r.length>0;){let n=r.pop(),i=this.byParentKey[n.Key];if(i)for(let a of i)(!t||!a.IsGroup)&&s.push(a),r.push(a)}return s}onClick(e,t,s){if(super.onClick(e,t,s),e.isDefaultPrevented()||l.SlickTreeHelper.toggleClick(e,t,s,this.view,a=>a.Key),e.isDefaultPrevented())return;let r=$(e.target),n=r.hasClass("grant");if(n||r.hasClass("revoke")){e.preventDefault();let a=this.itemAt(t),m=r.hasClass("checked")||r.hasClass("partial");if(m?n=null:n=n!==m,a.IsGroup)for(var i of this.getDescendants(a,!0))i.GrantRevoke=n;else a.GrantRevoke=n;this.slickGrid.invalidate()}}getParentKey(e){e.charAt(e.length-1)===":"&&(e=e.substr(0,e.length-1));let t=e.lastIndexOf(":");return t>=0?e.substr(0,t+1):null}getButtons(){return[]}createToolbarExtensions(){super.createToolbarExtensions(),l.GridUtils.addQuickSearchInputCustom(this.toolbar.element,(e,t)=>{this.searchText=Select2.util.stripDiacritics((0,o.trimToNull)(t)||"").toLowerCase(),this.view.setItems(this.view.getItems(),!0)})}getSortedGroupAndPermissionKeys(e){var n;let t=(0,o.getRemoteData)("Administration.PermissionKeys"),s={};for(var r of t){let i=r;if(!i||i.charAt(i.length-1)==":"&&(i=i.substr(0,i.length-1),i.length===0)||e[i])continue;e[i]=(n=(0,o.tryGetText)("Permission."+i))!=null?n:i;let a=i.split(":"),m="",h="";for(let u=0;u<a.length-1;u++){m=m+a[u]+":";let f=(0,o.tryGetText)("Permission."+m);f==null&&(f=a[u]),e[m]=f,h=h+e[m]+":",s[m]=h}s[i]=h+e[i]}return t=Object.keys(e),t=t.sort((i,a)=>(0,o.turkishLocaleCompare)(s[i],s[a])),t}get value(){let e=[];for(let t of this.view.getItems())t.GrantRevoke!=null&&t.Key.charAt(t.Key.length-1)!=":"&&e.push({PermissionKey:t.Key,Granted:t.GrantRevoke});return e}set value(e){var t;for(let s of this.view.getItems())s.GrantRevoke=null;if(e!=null)for(let s of e){let r=this.view.getItemById(s.PermissionKey);r&&(r.GrantRevoke=(t=s.Granted)!=null?t:!0)}this.setItems(this.getItems())}get rolePermissions(){return Object.keys(this._rolePermissions)}set rolePermissions(e){if(this._rolePermissions={},e)for(let t of e)this._rolePermissions[t]=!0;this.setItems(this.getItems())}set implicitPermissions(e){if(this._implicitPermissions={},e)for(var t of Object.keys(e)){this._implicitPermissions[t]=this._implicitPermissions[t]||{};var s=e[t];if(s)for(var r of s)this._implicitPermissions[t][r]=!0}}};p(c,"PermissionCheckEditor"),c=d([l.Decorators.registerEditor("AdminArea.Administration.PermissionCheckEditor",[l.IGetEditValue,l.ISetEditValue])],c);export{c as a};
//# sourceMappingURL=chunk-Y7D5V2LV.js.map
