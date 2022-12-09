import { NgForm, FormGroup, Validators, FormBuilder, FormControl } from "@angular/forms";
export class userdata{
    userName:string='';
    password:string='';
     CFname:string='';
     CLname :string='';
      CEmailId :string='';
      CMobileNumber:string='';
      UsType:string='';
    
    formLoginGroup: FormGroup;
    constructor() {
        var _builder = new FormBuilder();
        this.formLoginGroup = _builder.group({});
        
       this.formLoginGroup.addControl("userName",new FormControl('',Validators.required));

        
      
    }
}