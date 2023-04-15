import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { UserRegistrationDTO } from 'src/app/authentication/interfaces/user-registration';
import { RegistrationResponseDTO } from 'src/app/authentication/interfaces/registration-response';

@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {

  constructor(private http: HttpClient) { }

  public registerUser = (route: string, body: UserRegistrationDTO) => {
    return this.http.post<RegistrationResponseDTO> (this.createCompleteRoute(route, "https://localhost:7096"), body);
  }

  private createCompleteRoute = (route: string, envAddress: string) => {
    return `${envAddress}/${route}`;
  }
}
