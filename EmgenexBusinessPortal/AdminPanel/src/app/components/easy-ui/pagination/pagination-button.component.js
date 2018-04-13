/**
 * EasyUI for Angular 0.7
 * 
 * Copyright (c) 2009-2017 www.jeasyui.com. All rights reserved.
 *
 * Licensed under the freeware license: https://www.jeasyui.com/license_freeware2.php
 * To use it on other terms please contact us: info@jeasyui.com
 *
 */
var __extends=this&&this.__extends||function(){var extendStatics=Object.setPrototypeOf||{__proto__:[]}instanceof Array&&function(d,b){d.__proto__=b}||function(d,b){for(var p in b)b.hasOwnProperty(p)&&(d[p]=b[p])};return function(d,b){function __(){this.constructor=d}extendStatics(d,b),d.prototype=null===b?Object.create(b):(__.prototype=b.prototype,new __)}}();import{Component,Input,Host,Inject,forwardRef}from"@angular/core";import{PaginationComponent}from"./pagination.component";import{LinkButtonComponent,LINKBUTTON_TEMPLATE}from"../linkbutton/linkbutton.component";var PaginationButtonComponent=function(_super){function PaginationButtonComponent(pagination){var _this=_super.call(this)||this;return _this.pagination=pagination,_this.plain=!0,_this._disabled=!1,_this.click.subscribe(function(){"first"==_this.name?_this.pagination.selectPage(1):"prev"==_this.name?_this.pagination.selectPage(_this.pagination.pageNumber-1):"next"==_this.name?_this.pagination.selectPage(_this.pagination.pageNumber+1):"last"==_this.name?_this.pagination.selectPage(_this.pagination.pageCount):"refresh"==_this.name&&_this.pagination.refreshPage()}),_this}return __extends(PaginationButtonComponent,_super),Object.defineProperty(PaginationButtonComponent.prototype,"name",{get:function(){return this._name},set:function(value){this._name=value,this.iconCls="pagination-"+this.name},enumerable:!0,configurable:!0}),Object.defineProperty(PaginationButtonComponent.prototype,"iconCls",{get:function(){return"refresh"==this.name?this.pagination.loading?"pagination-loading":"pagination-load":this._iconCls},set:function(value){this._iconCls=value},enumerable:!0,configurable:!0}),Object.defineProperty(PaginationButtonComponent.prototype,"disabled",{get:function(){return"first"==this.name||"prev"==this.name?!this.pagination.total||1==this.pagination.pageNumber:"next"==this.name||"last"==this.name?this.pagination.pageNumber==this.pagination.pageCount:this._disabled},set:function(value){this._disabled=value},enumerable:!0,configurable:!0}),PaginationButtonComponent}(LinkButtonComponent);export{PaginationButtonComponent};PaginationButtonComponent.decorators=[{type:Component,args:[{selector:"eui-pagination-button",template:LINKBUTTON_TEMPLATE,host:{class:"f-inline-row"}}]}],PaginationButtonComponent.ctorParameters=function(){return[{type:PaginationComponent,decorators:[{type:Host},{type:Inject,args:[forwardRef(function(){return PaginationComponent})]}]}]},PaginationButtonComponent.propDecorators={plain:[{type:Input}],name:[{type:Input}],iconCls:[{type:Input}],disabled:[{type:Input}]};