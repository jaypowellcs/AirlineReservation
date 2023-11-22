import { Component } from '@angular/core';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent {

  // Initialization for ES Users
  showMenu = false;

  toggleNavbar(){
    this.showMenu = !this.showMenu;
  }
}
