﻿// Write your JavaScript code.
$(document).ready(function() {
    $('#add-item-error').hide();
    $('#add-item-button').on('click', addItem);
})

function addItem() {
    var newTitle = $('#add-item-title').val();
    var newDueDate = $('#add-item-dueDate').val();

    $.post('/Todo/AddItem', { title: newTitle, dueDate: newDueDate }, function() {
            window.location = '/Todo';
        })
        .fail(function(data) {
            if (data && data.responseJSON) {
                var firstError = data.responseJSON[Object.keys(data.responseJSON)[0]];
                $('#add-item-error').text(firstError);
                $('#add-item-error').show();
            }
        });
}