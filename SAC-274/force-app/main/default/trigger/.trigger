trigger PopulateMobile on Student__c (before insert, before update) {
  for(Student__c student : Trigger.new) {
    if(student.Phone != null && student.Mobile == null) {
      student.Mobile = student.Phone;
    }
  }
}