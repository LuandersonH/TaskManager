1. Criar o **endpoint** no Controller.  
2. Definir a função no **UseCase** (Delete/Update/GetById/GetAll/Register).  
3. Implementar o método `public void Execute(int props)`.  
4. No Controller, instanciar o UseCase: `var useCase = new DeleteTaskById();`.  
5. Executar a lógica: `useCase.Execute(id);`.  