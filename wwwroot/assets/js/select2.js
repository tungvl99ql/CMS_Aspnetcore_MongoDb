$(function(e) {
    'use strict'

    // Select2
    //$('.select2').select2({
    //    minimumResultsForSearch: Infinity,
    //    width: '100%'
    //});
    // Select2 by showing the search
    $('.select2-show-search-tungvip1').select2({
        minimumResultsForSearch:'',
        width: '100%',
        dropdownParent: $('#modaldemo8')
    });
    $('.select2-show-search1').select2({
        minimumResultsForSearch: '',
        width: '100%',
       
    });


    $('.select2-show-search').select2({
        minimumResultsForSearch: '',
        width: '100%',
    });

    //$('.select2').on('click', () => {
    //    let selectField = document.querySelectorAll('.select2-search__field')
    //    selectField.forEach((element, index) => {
    //        element.focus();
    //    })
    //});


    $('.select2-show-search-tungvip').select2({
        minimumResultsForSearch: '',
        width: '100%',
        allowClear: true,
        dropdownParent: $('#modaldemo8'),
        placeholder: 'This is my placeholder',
        language: {
            noResults: function () {
                return `<button style="width: 100%" type="button"
            class="btn btn-primary" 
            onClick='task()'>+ Add New Item</button>
            </li>`;
            }
        },

        escapeMarkup: function (markup) {
            return markup;
        }
    });

    $('.select2-show-search-tungvip2').select2({
        minimumResultsForSearch: '',
        width: '100%',
        allowClear: true,
        dropdownParent: $('#modaldemo8'),
        placeholder: 'This is my placeholder',
        language: {
            noResults: function () {
                return `<button style="width: 100%" type="button"
            class="btn btn-primary" 
            onClick='task2()'>+ Add New Item</button>
            </li>`;
            }
        },

        escapeMarkup: function (markup) {
            return markup;
        }
    });
});