import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root', // 🔹 Garante que o serviço seja injetado corretamente
})
export class TaskService {
  //Por ser apenas um projeto para desenvolver minhas skills em Angular, estou expondo a URL da API diretamente no código.
  //Em um projeto real, você deve usar um arquivo de configuração para armazenar a URL da API.
  private API_URL = 'http://localhost:8000/api/todo/';

  constructor(private http: HttpClient) {
    console.log('API URL:', this.API_URL);
  }

  getTasks(): Observable<any> {
    return this.http.get(`${this.API_URL}get_tasks`);
  }

  addTask(task: string): Observable<any> {
    return this.http.post(`${this.API_URL}add_task`, JSON.stringify(task), {
      headers: { 'Content-Type': 'application/json' },
    });
  }
  deleteTask(id: number): Observable<any> {
    return this.http.delete(`${this.API_URL}delete_task/${id}`);
  }
}
