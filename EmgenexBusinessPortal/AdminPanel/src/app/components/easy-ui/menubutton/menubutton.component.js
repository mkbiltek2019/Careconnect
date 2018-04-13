/**
 * EasyUI for Angular 0.7
 * 
 * Copyright (c) 2009-2017 www.jeasyui.com. All rights reserved.
 *
 * Licensed under the freeware license: https://www.jeasyui.com/license_freeware2.php
 * To use it on other terms please contact us: info@jeasyui.com
 *
 */
var __extends=this&&this.__extends||function(){var extendStatics=Object.setPrototypeOf||{__proto__:[]}instanceof Array&&function(d,b){d.__proto__=b}||function(d,b){for(var p in b)b.hasOwnProperty(p)&&(d[p]=b[p])};return function(d,b){function __(){this.constructor=d}extendStatics(d,b),d.prototype=null===b?Object.create(b):(__.prototype=b.prototype,new __)}}();import{Component,Input}from"@angular/core";import{LinkButtonComponent}from"../linkbutton/linkbutton.component";export var MENUBUTTON_TEMPLATE='\n\t<a #btnRef [attr.href]="href||\'#\'"\n\t\t\t[ngClass]="btnCls"\n\t\t\t[ngStyle]="btnStyle"\n\t\t\t[class]="getInnerCls()" \n\t\t\t(focus)="focus()" \n\t\t\t(blur)="blur()" \n\t\t\t(click)="onClick($event)"\n\t\t\t(click)="showMenu()"\n\t\t\t(mouseenter)="onMouseEnter($event)"\n\t\t\t(mouseleave)="onMouseLeave($event)">\n\t\t<span [class]="btnLeftCls">\n\t\t\t<span #textRef class="l-btn-text" [class.l-btn-empty]="!text"><ng-content></ng-content></span>\n\t\t\t<span [class]="btnIconCls"></span>\n\t\t\t<span class="m-btn-downarrow"></span>\n\t\t\t<span class="m-btn-line"></span>\n\t\t</span>\n\t</a>\n';var MenuButtonComponent=function(_super){function MenuButtonComponent(){var _this=null!==_super&&_super.apply(this,arguments)||this;return _this.menu=null,_this.menuAlign="left",_this.duration=100,_this.timer=null,_this}return __extends(MenuButtonComponent,_super),MenuButtonComponent.prototype.getInnerCls=function(){var cls=_super.prototype.getInnerCls.call(this);return cls+=" m-btn m-btn-"+this.size,this.menu&&!this.menu.closed&&(cls+=this.plain?" m-btn-plain-active":" m-btn-active"),cls},MenuButtonComponent.prototype.onMouseEnter=function(event){var _this=this;this.disabled||(this.timer=setTimeout(function(){_this.showMenu()},this.duration))},MenuButtonComponent.prototype.onMouseLeave=function(event){this.disabled||(clearTimeout(this.timer),this.menu&&this.menu.delayHide())},MenuButtonComponent.prototype.showMenu=function(){this.disabled||this.menu&&this.menu.showAt(this.btnRef.nativeElement,this.menuAlign)},MenuButtonComponent}(LinkButtonComponent);export{MenuButtonComponent};MenuButtonComponent.decorators=[{type:Component,args:[{selector:"eui-menubutton",template:MENUBUTTON_TEMPLATE,host:{class:"f-inline-row"}}]}],MenuButtonComponent.ctorParameters=function(){return[]},MenuButtonComponent.propDecorators={menu:[{type:Input}],menuAlign:[{type:Input}],duration:[{type:Input}]};