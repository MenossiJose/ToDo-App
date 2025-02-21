import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-task',
  templateUrl: './task.component.html',
  styleUrls: ['./task.component.css'],
})
export class TaskComponent {
  // Permite que o componente receba a propriedade 'task'
  @Input() task: any;

  // Evento que será emitido para o componente pai quando uma tarefa for deletada
  @Output() deleteTaskEvent = new EventEmitter<number>();

  deleteTask() {
    this.deleteTaskEvent.emit(this.task.id); // Certifique-se de que `task.id` é um número
  }
}
